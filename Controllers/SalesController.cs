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
        private readonly List<Category> _categories;
        private readonly List<Product> _products;

        public SalesController(SalesAndBillingForm form)
        {
            _form = form;
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();

            _categories = _categoryRepository.SelectAll();
            _products = _productRepository.SelectAll();
        }

        public void OpenForm()
        {
            GenerateCategoryComponents();
            _form.Show();
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
                btnProduct.Text = product.Name;
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
            _form.GetTxtFormula().Text = btnProduct.Text;
        }
    }
}
