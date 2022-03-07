namespace RetailStoreCashRegister.Forms
{
    partial class AdministrationAndStatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.categoryTabPage = new System.Windows.Forms.TabPage();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.cbUnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUnitOfMeasure = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.statsTabPage = new System.Windows.Forms.TabPage();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.dateTimePickerStats = new System.Windows.Forms.DateTimePicker();
            this.adminTabControl.SuspendLayout();
            this.categoryTabPage.SuspendLayout();
            this.productTabPage.SuspendLayout();
            this.statsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.categoryTabPage);
            this.adminTabControl.Controls.Add(this.productTabPage);
            this.adminTabControl.Controls.Add(this.statsTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(1, 2);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(798, 446);
            this.adminTabControl.TabIndex = 1;
            // 
            // categoryTabPage
            // 
            this.categoryTabPage.Controls.Add(this.listBoxCategory);
            this.categoryTabPage.Controls.Add(this.btnUpdateCategory);
            this.categoryTabPage.Controls.Add(this.btnDeleteCategory);
            this.categoryTabPage.Controls.Add(this.btnAddCategory);
            this.categoryTabPage.Controls.Add(this.txtCategory);
            this.categoryTabPage.Controls.Add(this.lblCategoryName);
            this.categoryTabPage.Location = new System.Drawing.Point(4, 24);
            this.categoryTabPage.Name = "categoryTabPage";
            this.categoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoryTabPage.Size = new System.Drawing.Size(790, 418);
            this.categoryTabPage.TabIndex = 0;
            this.categoryTabPage.Text = "Manage categories";
            this.categoryTabPage.UseVisualStyleBackColor = true;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 15;
            this.listBoxCategory.Location = new System.Drawing.Point(275, 7);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(387, 364);
            this.listBoxCategory.TabIndex = 5;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Enabled = false;
            this.btnUpdateCategory.Location = new System.Drawing.Point(46, 146);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Enabled = false;
            this.btnDeleteCategory.Location = new System.Drawing.Point(46, 175);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(46, 117);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(188, 23);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(46, 70);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(188, 23);
            this.txtCategory.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(46, 52);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(91, 15);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category name:";
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.cbUnitOfMeasure);
            this.productTabPage.Controls.Add(this.listBoxProduct);
            this.productTabPage.Controls.Add(this.btnUpdateProduct);
            this.productTabPage.Controls.Add(this.btnDeleteProduct);
            this.productTabPage.Controls.Add(this.btnAddProduct);
            this.productTabPage.Controls.Add(this.txtProductPrice);
            this.productTabPage.Controls.Add(this.txtProductName);
            this.productTabPage.Controls.Add(this.cbCategory);
            this.productTabPage.Controls.Add(this.lblProductName);
            this.productTabPage.Controls.Add(this.lblPrice);
            this.productTabPage.Controls.Add(this.lblUnitOfMeasure);
            this.productTabPage.Controls.Add(this.lblCategory);
            this.productTabPage.Location = new System.Drawing.Point(4, 24);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productTabPage.Size = new System.Drawing.Size(790, 418);
            this.productTabPage.TabIndex = 1;
            this.productTabPage.Text = "Manage products";
            this.productTabPage.UseVisualStyleBackColor = true;
            // 
            // cbUnitOfMeasure
            // 
            this.cbUnitOfMeasure.FormattingEnabled = true;
            this.cbUnitOfMeasure.Location = new System.Drawing.Point(9, 253);
            this.cbUnitOfMeasure.Name = "cbUnitOfMeasure";
            this.cbUnitOfMeasure.Size = new System.Drawing.Size(196, 23);
            this.cbUnitOfMeasure.TabIndex = 13;
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 15;
            this.listBoxProduct.Location = new System.Drawing.Point(257, 7);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(405, 364);
            this.listBoxProduct.TabIndex = 12;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.Location = new System.Drawing.Point(8, 320);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(197, 23);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(9, 349);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(197, 23);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(8, 291);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(197, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(9, 179);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(196, 23);
            this.txtProductPrice.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(9, 110);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 23);
            this.txtProductName.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(9, 39);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(196, 23);
            this.cbCategory.TabIndex = 5;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(9, 92);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(85, 15);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 161);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Product price:";
            // 
            // lblUnitOfMeasure
            // 
            this.lblUnitOfMeasure.AutoSize = true;
            this.lblUnitOfMeasure.Location = new System.Drawing.Point(9, 235);
            this.lblUnitOfMeasure.Name = "lblUnitOfMeasure";
            this.lblUnitOfMeasure.Size = new System.Drawing.Size(94, 15);
            this.lblUnitOfMeasure.TabIndex = 1;
            this.lblUnitOfMeasure.Text = "Unit of measure:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(9, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // statsTabPage
            // 
            this.statsTabPage.Controls.Add(this.panelStatistics);
            this.statsTabPage.Controls.Add(this.dateTimePickerStats);
            this.statsTabPage.Location = new System.Drawing.Point(4, 24);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statsTabPage.Size = new System.Drawing.Size(790, 418);
            this.statsTabPage.TabIndex = 2;
            this.statsTabPage.Text = "Statistics overview";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // panelStatistics
            // 
            this.panelStatistics.AutoScroll = true;
            this.panelStatistics.Location = new System.Drawing.Point(8, 78);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(776, 251);
            this.panelStatistics.TabIndex = 1;
            // 
            // dateTimePickerStats
            // 
            this.dateTimePickerStats.Location = new System.Drawing.Point(228, 36);
            this.dateTimePickerStats.Name = "dateTimePickerStats";
            this.dateTimePickerStats.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerStats.TabIndex = 0;
            // 
            // AdministrationAndStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdministrationAndStatisticsForm";
            this.Text = "Administration and statistics";
            this.adminTabControl.ResumeLayout(false);
            this.categoryTabPage.ResumeLayout(false);
            this.categoryTabPage.PerformLayout();
            this.productTabPage.ResumeLayout(false);
            this.productTabPage.PerformLayout();
            this.statsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl adminTabControl;
        private TabPage categoryTabPage;
        private ListBox listBoxCategory;
        private Button btnUpdateCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private TextBox txtCategory;
        private Label lblCategoryName;
        private TabPage productTabPage;
        private ComboBox cbUnitOfMeasure;
        private ListBox listBoxProduct;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private ComboBox cbCategory;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblUnitOfMeasure;
        private Label lblCategory;
        private TabPage statsTabPage;
        private Panel panelStatistics;
        private DateTimePicker dateTimePickerStats;
    }
}