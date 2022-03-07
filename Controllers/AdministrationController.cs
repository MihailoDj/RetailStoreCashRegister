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
    public class AdministrationController
    {
        private readonly CategoryRepository _categoryRepository;
        private AdministrationAndStatisticsForm _form;
        private List<Category> _categories;

        public AdministrationController(AdministrationAndStatisticsForm form)
        {
            _form = form;
            _categoryRepository = new CategoryRepository();
            _categories = GetCategories();
        }

        private void AddEventHandlers()
        {
            _form.GetTxtCategory().TextChanged += new EventHandler(CheckTxtCategoryLength);
            _form.GetBtnAddCategory().Click += new EventHandler(AddCategory);
            _form.GetListBoxCategory().SelectedIndexChanged += new EventHandler(CheckSelectedIndex);
            _form.GetBtnUpdateCategory().Click += new EventHandler(UpdateCategory);
            _form.GetBtnDeleteCategory().Click += new EventHandler(DeleteCategory);
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
                MessageBox.Show("Name field cannot be empty.");
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

        private void CheckSelectedIndex(object? sender, EventArgs e)
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
