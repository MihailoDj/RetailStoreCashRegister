using RetailStoreCashRegister.Forms;
using RetailStoreCashRegister.Models;
using RetailStoreCashRegister.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Controllers
{
    public class AdministrationController
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        private readonly InvoiceRepository _invoiceRepository;
        private readonly AdministrationAndStatisticsForm _form;
        private readonly List<Category> _categories;
        private readonly List<Product> _products;

        public AdministrationController(AdministrationAndStatisticsForm form)
        {
            _form = form;
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            _invoiceRepository = new InvoiceRepository();
            _categories = GetCategories();
            _products = GetProducts();
        }

        private void AddEventHandlers()
        {
            //Event handlers for the category management tab
            _form.GetTxtCategory().TextChanged += new EventHandler(CheckTxtCategoryLength);
            _form.GetBtnAddCategory().Click += new EventHandler(AddCategory);
            _form.GetListBoxCategory().SelectedIndexChanged += new EventHandler(CheckLBCategorySelectedIndex);
            _form.GetBtnUpdateCategory().Click += new EventHandler(UpdateCategory);
            _form.GetBtnDeleteCategory().Click += new EventHandler(DeleteCategory);

            //Event handlers for the product management tab
            _form.GetBtnAddProduct().Click += new EventHandler(AddProduct);
            _form.GetTxtProductName().TextChanged += new EventHandler(CheckTxtProductNameLength);
            _form.GetListBoxProduct().SelectedIndexChanged += new EventHandler(CheckLBProductSelectedIndex);
            _form.GetBtnUpdateProduct().Click += new EventHandler(UpdateProduct);
            _form.GetBtnDeleteProduct().Click += new EventHandler(DeleteProduct);

            //Event handlers for the statistics tab
            _form.GetDateTimePickerStats().ValueChanged += new EventHandler(LoadStatsForDate);
        }

        private void LoadStatsForDate(object? sender, EventArgs e)
        {
            _form.GetPanelStatistics().Controls.Clear();

            DateTime selectedDate = _form.GetDateTimePickerStats().Value;
            List<Invoice> invoices = _invoiceRepository.SelectStatistics(selectedDate);

            var panelPosX = 10;
            var panelPosY = 15;

            foreach (Invoice i in invoices)
            {
                GroupBox invoiceGroupBox = new GroupBox();
                invoiceGroupBox.Location = new Point(panelPosX, panelPosY);
                invoiceGroupBox.Height = 300;
                invoiceGroupBox.Width = 730;
                invoiceGroupBox.Text = $"Invoice {i.Id} - {i.BillingDate.Date}";

                var locationY = 30;

                foreach (KeyValuePair<Product, double> p in i.ProductAmounts)
                {
                    //for the name label
                    Label lblName = new Label();
                    lblName.Height = 50;
                    lblName.Width = 100;
                    lblName.Text = p.Key.Name;
                    lblName.Name = p.Key.Name.ToString();
                    lblName.Location = new Point(10, locationY);

                    //for the amount label
                    Label lblAmount = new Label();
                    lblAmount.Height = 50;
                    lblAmount.Width = 50;
                    lblAmount.Text = p.Value.ToString();
                    lblAmount.Location = new Point(700, locationY);

                    invoiceGroupBox.Controls.Add(lblAmount);
                    invoiceGroupBox.Controls.Add(lblName);

                    //for the progress bar
                    ProgressBar pb = new ProgressBar();
                    pb.Maximum = 30;
                    pb.Height = 20;
                    pb.Width = 550;
                    pb.Value = Convert.ToInt32(p.Value);
                    pb.Location = new Point(100, locationY);

                    invoiceGroupBox.Controls.Add(pb);

                    locationY += 50;
                }

                panelPosY += invoiceGroupBox.Height + 20;
                _form.GetPanelStatistics().Controls.Add(invoiceGroupBox);
            }
        }

        private void DeleteProduct(object? sender, EventArgs e)
        {
            try
            {

                Product product = _form.GetListBoxProduct().SelectedItem as Product;

                _productRepository.Delete(product);

                MessageBox.Show("Product successfully deleted.", "Success");

                _products.Remove(product);
                FillListBoxProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UpdateProduct(object? sender, EventArgs e)
        {
            if (ValidateProductForm())
            {
                try
                {

                    Product product = _form.GetListBoxProduct().SelectedItem as Product;

                    product.Category = _form.GetCbCategory().SelectedItem as Category;
                    product.Name = _form.GetTxtProductName().Text.Trim();
                    product.Price = double.Parse(_form.GetTxtProductPrice().Text, CultureInfo.InvariantCulture);
                    product.UnitOfMeasure = (Enums.UnitOfMeasure)_form.GetCbUnitOfMeasure().SelectedItem;
                    

                    _productRepository.Update(product);

                    FillListBoxProduct();

                    MessageBox.Show("Product successfully updated.", "Success");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void CheckLBProductSelectedIndex(object? sender, EventArgs e)
        {
            _form.GetBtnUpdateProduct().Enabled = _form.GetListBoxProduct().SelectedIndex != -1;
            _form.GetBtnDeleteProduct().Enabled = _form.GetListBoxProduct().SelectedIndex != -1;

            if (_form.GetListBoxProduct().SelectedItem != null)
            {
                Product selectedProduct = _form.GetListBoxProduct().SelectedItem as Product;

                _form.GetCbCategory().SelectedItem = selectedProduct.Category;
                _form.GetCbUnitOfMeasure().SelectedItem = selectedProduct.UnitOfMeasure;
                _form.GetTxtProductName().Text = selectedProduct.Name;
                _form.GetTxtProductPrice().Text = selectedProduct.Price.ToString();
            }
        }

        private void CheckTxtProductNameLength(object? sender, EventArgs e)
        {
            _form.GetBtnAddProduct().Enabled = _form.GetTxtProductName().TextLength > 0;
        }

        private void AddProduct(object? sender, EventArgs e)
        {
            if (ValidateProductForm())
            {
                try
                {

                    Product product = new Product
                    {
                        Category = _form.GetCbCategory().SelectedItem as Category,
                        Name = _form.GetTxtProductName().Text.Trim(),
                        Price = double.Parse(_form.GetTxtProductPrice().Text, CultureInfo.InvariantCulture),
                        UnitOfMeasure = (Enums.UnitOfMeasure)_form.GetCbUnitOfMeasure().SelectedItem
                    };

                    _productRepository.Insert(product);
                    _products.Add(product);

                    FillListBoxProduct();

                    MessageBox.Show("Product successfully added.", "Success");

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private bool ValidateProductForm()
        {
            if (_form.GetCbCategory().SelectedItem == null)
            {
                MessageBox.Show("Product must have a category.", "Validation error.");
                return false;
            }

            if (_form.GetTxtProductName().TextLength == 0)
            {
                MessageBox.Show("Product must have a name.", "Validation error.");
                return false;
            }


            if (double.Parse(_form.GetTxtProductPrice().Text, CultureInfo.InvariantCulture) < 0)
            {
                MessageBox.Show($"Product must have a valid price", "Validation error.");
                return false;
            }

            return true;
        }

        private List<Product> GetProducts()
        {
            try
            {
                return _productRepository.SelectAll();

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error");

                return null;
            }
        }

        private void DeleteCategory(object? sender, EventArgs e)
        {
            try
            {
                Category cat = _form.GetListBoxCategory().SelectedItem as Category;

                _categoryRepository.Delete(cat);

                MessageBox.Show($"Category {cat.Name} successfully deleted.", "Success");

                _categories.Remove(cat);
                FillCbCategory();
                FillListBoxCategory();
            } catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UpdateCategory(object? sender, EventArgs e)
        {
            if (_form.GetTxtCategory().TextLength == 0) 
            { 
                MessageBox.Show("Name field cannot be empty.", "Validation error");
                return;
            }

            try
            {
                Category cat = _form.GetListBoxCategory().SelectedItem as Category;

                string oldName = cat.Name;
                cat.Name = _form.GetTxtCategory().Text;

                _categoryRepository.Update(cat);

                FillCbCategory();
                FillListBoxCategory();

                _form.GetTxtCategory().ResetText();

                MessageBox.Show($"Category {oldName} successfully updated.", "Success");

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CheckLBCategorySelectedIndex(object? sender, EventArgs e)
        {
             _form.GetBtnUpdateCategory().Enabled = _form.GetListBoxCategory().SelectedIndex != -1;
             _form.GetBtnDeleteCategory().Enabled = _form.GetListBoxCategory().SelectedIndex != -1;
               
        }

        private void AddCategory(object? sender, EventArgs e)
        {
            Category cat = new(_form.GetTxtCategory().Text);

            try
            {
                _categoryRepository.Insert(cat);
                _categories.Add(cat);

                FillCbCategory();
                FillListBoxCategory();

                _form.GetTxtCategory().ResetText();

                MessageBox.Show($"Category {cat.Name} successfully added.", "Success");

            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CheckTxtCategoryLength(object? sender, EventArgs e)
        {
            _form.GetBtnAddCategory().Enabled = _form.GetTxtCategory().TextLength > 0;
        }

        public List<Category> GetCategories()
        {
            try
            {
                return _categoryRepository.SelectAll();

            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error");

                return null;
            }
        }

        public void OpenForm()
        {
            PrepareForm();

            _form.Show();
        }

        private void PrepareForm()
        {
            AddEventHandlers();

            _form.ActiveControl = _form.GetTxtCategory();

            FillCbCategory();
            FillCbUnitOfMeasure();
            FillListBoxCategory();
            FillListBoxProduct();
        }

        private void FillListBoxProduct()
        {
            _form.GetListBoxProduct().DataSource = null;
            _form.GetListBoxProduct().Items.Clear();

            _form.GetListBoxProduct().DataSource = _products;
            _form.GetListBoxProduct().DisplayMember = "name";
            _form.GetListBoxProduct().ValueMember = "name";
        }

        private void FillCbCategory()
        {
            _form.GetCbCategory().DataSource = null;
            _form.GetCbCategory().Items.Clear();

            _form.GetCbCategory().DataSource = _categories;
            _form.GetCbCategory().DisplayMember = "name";
        }

        private void FillCbUnitOfMeasure()
        {
            _form.GetCbUnitOfMeasure().DataSource = Enum.GetValues(typeof(Enums.UnitOfMeasure));
        }

        private void FillListBoxCategory()
        {
            _form.GetListBoxCategory().DataSource = null;
            _form.GetListBoxCategory().Items.Clear();

            _form.GetListBoxCategory().DisplayMember = "name";
            _form.GetListBoxCategory().ValueMember = "name";
            _form.GetListBoxCategory().DataSource = _categories;
        }
    }
}
