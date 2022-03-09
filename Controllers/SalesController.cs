using RetailStoreCashRegister.Forms;
using RetailStoreCashRegister.Models;
using RetailStoreCashRegister.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Controllers
{
    public class SalesController
    {
        private readonly SalesAndBillingForm _form;
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        private readonly InvoiceRepository _invoiceRepository;
        private readonly List<Category> _categories;
        private readonly List<Product> _products;
        private Invoice _invoice;

        public SalesController(SalesAndBillingForm form)
        {
            _form = form;
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            _invoiceRepository = new InvoiceRepository();

            _categories = _categoryRepository.SelectAll();
            _products = _productRepository.SelectAll();

            _invoice = new Invoice();
        }

        public void OpenForm()
        {
            AddEventHandlers();
            GenerateCategoryComponents();
            _form.Show();
        }

        private void AddEventHandlers()
        {
            _form.GetBtnInsert0().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert1().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert2().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert3().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert4().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert5().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert6().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert7().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert8().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsert9().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnInsertComma().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnTimes().Click += new EventHandler(AddSymbolToFormula);
            _form.GetBtnEnter().Click += new EventHandler(EnterProductIntoInvoice);
            _form.GetBtnDeleteFormulaCharacter().Click += new EventHandler(DeleteFormulaCharacter);
            _form.GetBtnClearFormula().Click += new EventHandler(ClearFormula);
            _form.GetBtnCheckout().Click += new EventHandler(CheckoutInvoice);
            _form.GetBtnDeleteInvoiceItem().Click += new EventHandler(DeleteInvoiceItem);
            _form.GetBtnSaveInvoice().Click += new EventHandler(SaveInvoice);
        }

        private void SaveInvoice(object? sender, EventArgs e)
        {
            try
            {
                _invoice.BillingDate = DateTime.Now;
                _invoiceRepository.Insert(_invoice);

                MessageBox.Show("Invoice successfully saved. Visit the administration panel for aditional info.", "Success");
                _invoice = new Invoice();
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DeleteInvoiceItem(object? sender, EventArgs e)
        {
            string? selectedProduct = _form.GetListBoxEntry().SelectedItem.ToString();

            if (selectedProduct == null)
            {
                MessageBox.Show("No product is selected. Unable to delete.", "Error.");
                return;
            }

            string productName = selectedProduct[..(selectedProduct.IndexOf("(") - 1)];
            Product product = _invoice.ProductAmounts.Keys.Where(p => p.Name == productName).First();
            _invoice.ProductAmounts.Remove(product);
            _form.GetLblTotalPrice().Text = _invoice.ComputeTotalPrice().ToString();

            _form.GetListBoxEntry().Items.Remove(selectedProduct);
        }

        private void CheckoutInvoice(object? sender, EventArgs e)
        {
            //ToDo: Consider addding currency characters.

            _form.GetTablControlInvoice().SelectedIndex = 1;

            foreach (Product product in _invoice.ProductAmounts.Keys)
            {
                _form.GetListBoxInvoice().Items.Add(
                $"{product.Name}\t\t{product.Price} * {_invoice.ProductAmounts.GetValueOrDefault(product)}");
            }

            _form.GetListBoxInvoice().Items.Add("------------");
            _form.GetListBoxInvoice().Items.Add("Total price:");
            _form.GetListBoxInvoice().Items.Add(_invoice.ComputeTotalPrice());
        }

        private void ClearFormula(object? sender, EventArgs e)
        {
            _form.GetTxtFormula().ResetText();
        }

        private void DeleteFormulaCharacter(object? sender, EventArgs e)
        {
            string formula = _form.GetTxtFormula().Text;

            if (formula.Length > 0)
                _form.GetTxtFormula().Text = formula[0..^1];
        }

        private void EnterProductIntoInvoice(object? sender, EventArgs e)
        {
            try
            {
                //ToDo: do some actual validation

                string formula = _form.GetTxtFormula().Text;
                string productName = formula[..(formula.IndexOf("x") - 1)];

                double amount = Convert.ToDouble(formula[(formula.IndexOf("x") + 1)..]);

                Product product = _products.Find(p => p.Name == productName);

                if (product == null)
                {
                    MessageBox.Show("Product not found", "Error");
                    return;
                }

                _invoice.ProductAmounts.Add(product, amount);

                _form.GetLblTotalPrice().Text = _invoice.ComputeTotalPrice().ToString();

                _form.GetListBoxEntry().Items.Add($"{product.Name} ({amount} {product.UnitOfMeasure})");
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                MessageBox.Show("Invalid input.", "Error");
            }
        }

        private void AddSymbolToFormula(object? sender, EventArgs e)
        {
            Button btnInsertSymbol = sender as Button;

            if (btnInsertSymbol.Text == "X")
                _form.GetTxtFormula().Text += " x ";
            else
                _form.GetTxtFormula().Text += btnInsertSymbol.Text;
        }

        private void GenerateCategoryComponents()
        {
            var locationX = 10;

            foreach (Category cat in _categories)
            {

                Button btnCategory = new Button();

                btnCategory.Height = 50;
                btnCategory.Width = 100;
                btnCategory.Text = cat.Name;
                btnCategory.Name = cat.Name;
                btnCategory.Location = new Point(locationX, 10);

                btnCategory.Click += new EventHandler(GenerateProductComponents);
                _form.GetPanelCategories().Controls.Add(btnCategory);

                locationX += 110;
            }
        }

        private void GenerateProductComponents(object? sender, EventArgs e)
        {
            _form.GetFlowLayoutPanelProducts().Controls.Clear();

            var btnSelectedCategory = sender as Button;
            btnSelectedCategory.BackColor = Color.FromArgb(245, 160, 35);

            //Resets the color of all other category buttons
            foreach(Button btn in _form.GetPanelCategories().Controls)
            {
                if (btn.Name != btnSelectedCategory.Name)
                {
                    btn.BackColor = SystemColors.ButtonFace;
                    btn.UseVisualStyleBackColor = true;
                }
            }

            string categoryName = btnSelectedCategory.Text;
            var locationX = 10;

            foreach (Product product in _products.Where(p => p.Category.Name == categoryName))
            {

                Button btnProduct = new Button();

                btnProduct.Height = 50;
                btnProduct.Width = 100;
                btnProduct.Text = $"{product.Name} \n({product.Price} per {product.UnitOfMeasure})";
                btnProduct.Name = product.Name;
                btnProduct.Location = new Point(locationX, 10);
                btnProduct.Click += new EventHandler(AddProductToFormula);

                _form.GetFlowLayoutPanelProducts().Controls.Add(btnProduct);

                locationX += 110;
            }
        }

        private void AddProductToFormula(object? sender, EventArgs e)
        {
            var btnProduct = sender as Button;
            _form.GetTxtFormula().Text = btnProduct.Name;
        }
    }
}
