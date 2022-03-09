namespace RetailStoreCashRegister.Forms
{
    partial class SalesAndBillingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlInvoice = new System.Windows.Forms.TabControl();
            this.tb_unos = new System.Windows.Forms.TabPage();
            this.lblTotalPriceText = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.listBoxEntry = new System.Windows.Forms.ListBox();
            this.btnDeleteInvoiceItem = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.listBoxInvoice = new System.Windows.Forms.ListBox();
            this.lbl_ukupna_cena = new System.Windows.Forms.Label();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearFormula = new System.Windows.Forms.Button();
            this.btnDeleteFormulaCharacter = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnInsertComma = new System.Windows.Forms.Button();
            this.btnInsert3 = new System.Windows.Forms.Button();
            this.btnInsert6 = new System.Windows.Forms.Button();
            this.btnInsert9 = new System.Windows.Forms.Button();
            this.btnInsert2 = new System.Windows.Forms.Button();
            this.btnInsert5 = new System.Windows.Forms.Button();
            this.btnInsert8 = new System.Windows.Forms.Button();
            this.btnInsert0 = new System.Windows.Forms.Button();
            this.btnInsert1 = new System.Windows.Forms.Button();
            this.btnInsert4 = new System.Windows.Forms.Button();
            this.btnInsert7 = new System.Windows.Forms.Button();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.btnTimes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControlInvoice.SuspendLayout();
            this.tb_unos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControlInvoice);
            this.groupBox1.Controls.Add(this.lbl_ukupna_cena);
            this.groupBox1.Controls.Add(this.btnNewTransaction);
            this.groupBox1.Location = new System.Drawing.Point(496, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 271);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mange invoice";
            // 
            // tabControlInvoice
            // 
            this.tabControlInvoice.Controls.Add(this.tb_unos);
            this.tabControlInvoice.Controls.Add(this.tabPage2);
            this.tabControlInvoice.Location = new System.Drawing.Point(6, 52);
            this.tabControlInvoice.Name = "tabControlInvoice";
            this.tabControlInvoice.SelectedIndex = 0;
            this.tabControlInvoice.Size = new System.Drawing.Size(377, 213);
            this.tabControlInvoice.TabIndex = 1;
            // 
            // tb_unos
            // 
            this.tb_unos.Controls.Add(this.lblTotalPriceText);
            this.tb_unos.Controls.Add(this.lblTotalPrice);
            this.tb_unos.Controls.Add(this.listBoxEntry);
            this.tb_unos.Controls.Add(this.btnDeleteInvoiceItem);
            this.tb_unos.Controls.Add(this.btnCheckout);
            this.tb_unos.Location = new System.Drawing.Point(4, 24);
            this.tb_unos.Name = "tb_unos";
            this.tb_unos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_unos.Size = new System.Drawing.Size(369, 185);
            this.tb_unos.TabIndex = 0;
            this.tb_unos.Text = "Entry/Proccessing";
            this.tb_unos.UseVisualStyleBackColor = true;
            // 
            // lblTotalPriceText
            // 
            this.lblTotalPriceText.AutoSize = true;
            this.lblTotalPriceText.Location = new System.Drawing.Point(271, 15);
            this.lblTotalPriceText.Name = "lblTotalPriceText";
            this.lblTotalPriceText.Size = new System.Drawing.Size(64, 15);
            this.lblTotalPriceText.TabIndex = 5;
            this.lblTotalPriceText.Text = "Total price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(271, 41);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(28, 15);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0,00";
            // 
            // listBoxEntry
            // 
            this.listBoxEntry.FormattingEnabled = true;
            this.listBoxEntry.ItemHeight = 15;
            this.listBoxEntry.Location = new System.Drawing.Point(3, 6);
            this.listBoxEntry.Name = "listBoxEntry";
            this.listBoxEntry.Size = new System.Drawing.Size(262, 169);
            this.listBoxEntry.TabIndex = 0;
            // 
            // btnDeleteInvoiceItem
            // 
            this.btnDeleteInvoiceItem.Location = new System.Drawing.Point(271, 116);
            this.btnDeleteInvoiceItem.Name = "btnDeleteInvoiceItem";
            this.btnDeleteInvoiceItem.Size = new System.Drawing.Size(92, 31);
            this.btnDeleteInvoiceItem.TabIndex = 3;
            this.btnDeleteInvoiceItem.Text = "Delete item";
            this.btnDeleteInvoiceItem.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(271, 153);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(92, 22);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout =>";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveInvoice);
            this.tabPage2.Controls.Add(this.listBoxInvoice);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(277, 140);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(86, 33);
            this.btnSaveInvoice.TabIndex = 1;
            this.btnSaveInvoice.Text = "Save";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            // 
            // listBoxInvoice
            // 
            this.listBoxInvoice.FormattingEnabled = true;
            this.listBoxInvoice.ItemHeight = 15;
            this.listBoxInvoice.Location = new System.Drawing.Point(6, 4);
            this.listBoxInvoice.Name = "listBoxInvoice";
            this.listBoxInvoice.Size = new System.Drawing.Size(265, 169);
            this.listBoxInvoice.TabIndex = 0;
            // 
            // lbl_ukupna_cena
            // 
            this.lbl_ukupna_cena.AutoSize = true;
            this.lbl_ukupna_cena.Location = new System.Drawing.Point(4, 168);
            this.lbl_ukupna_cena.Name = "lbl_ukupna_cena";
            this.lbl_ukupna_cena.Size = new System.Drawing.Size(0, 15);
            this.lbl_ukupna_cena.TabIndex = 4;
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(254, 12);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(129, 34);
            this.btnNewTransaction.TabIndex = 0;
            this.btnNewTransaction.Text = "New transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(4, 91);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(482, 443);
            this.flowLayoutPanelProducts.TabIndex = 13;
            // 
            // panelCategories
            // 
            this.panelCategories.AutoScroll = true;
            this.panelCategories.Location = new System.Drawing.Point(4, 0);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(482, 84);
            this.panelCategories.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearFormula);
            this.groupBox2.Controls.Add(this.btnDeleteFormulaCharacter);
            this.groupBox2.Controls.Add(this.btnEnter);
            this.groupBox2.Controls.Add(this.btnInsertComma);
            this.groupBox2.Controls.Add(this.btnInsert3);
            this.groupBox2.Controls.Add(this.btnInsert6);
            this.groupBox2.Controls.Add(this.btnInsert9);
            this.groupBox2.Controls.Add(this.btnInsert2);
            this.groupBox2.Controls.Add(this.btnInsert5);
            this.groupBox2.Controls.Add(this.btnInsert8);
            this.groupBox2.Controls.Add(this.btnInsert0);
            this.groupBox2.Controls.Add(this.btnInsert1);
            this.groupBox2.Controls.Add(this.btnInsert4);
            this.groupBox2.Controls.Add(this.btnInsert7);
            this.groupBox2.Controls.Add(this.txtFormula);
            this.groupBox2.Controls.Add(this.btnTimes);
            this.groupBox2.Location = new System.Drawing.Point(496, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 257);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation";
            // 
            // btnClearFormula
            // 
            this.btnClearFormula.Location = new System.Drawing.Point(260, 206);
            this.btnClearFormula.Name = "btnClearFormula";
            this.btnClearFormula.Size = new System.Drawing.Size(119, 45);
            this.btnClearFormula.TabIndex = 22;
            this.btnClearFormula.Text = "Clear all";
            this.btnClearFormula.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFormulaCharacter
            // 
            this.btnDeleteFormulaCharacter.Location = new System.Drawing.Point(260, 153);
            this.btnDeleteFormulaCharacter.Name = "btnDeleteFormulaCharacter";
            this.btnDeleteFormulaCharacter.Size = new System.Drawing.Size(119, 47);
            this.btnDeleteFormulaCharacter.TabIndex = 21;
            this.btnDeleteFormulaCharacter.Text = "Delete";
            this.btnDeleteFormulaCharacter.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(260, 51);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 45);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnInsertComma
            // 
            this.btnInsertComma.Location = new System.Drawing.Point(108, 206);
            this.btnInsertComma.Name = "btnInsertComma";
            this.btnInsertComma.Size = new System.Drawing.Size(45, 45);
            this.btnInsertComma.TabIndex = 19;
            this.btnInsertComma.Text = ",";
            this.btnInsertComma.UseVisualStyleBackColor = true;
            // 
            // btnInsert3
            // 
            this.btnInsert3.Location = new System.Drawing.Point(108, 153);
            this.btnInsert3.Name = "btnInsert3";
            this.btnInsert3.Size = new System.Drawing.Size(45, 45);
            this.btnInsert3.TabIndex = 18;
            this.btnInsert3.Text = "3";
            this.btnInsert3.UseVisualStyleBackColor = true;
            // 
            // btnInsert6
            // 
            this.btnInsert6.Location = new System.Drawing.Point(108, 102);
            this.btnInsert6.Name = "btnInsert6";
            this.btnInsert6.Size = new System.Drawing.Size(45, 45);
            this.btnInsert6.TabIndex = 17;
            this.btnInsert6.Text = "6";
            this.btnInsert6.UseVisualStyleBackColor = true;
            // 
            // btnInsert9
            // 
            this.btnInsert9.Location = new System.Drawing.Point(108, 51);
            this.btnInsert9.Name = "btnInsert9";
            this.btnInsert9.Size = new System.Drawing.Size(45, 45);
            this.btnInsert9.TabIndex = 16;
            this.btnInsert9.Text = "9";
            this.btnInsert9.UseVisualStyleBackColor = true;
            // 
            // btnInsert2
            // 
            this.btnInsert2.Location = new System.Drawing.Point(57, 153);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Size = new System.Drawing.Size(45, 45);
            this.btnInsert2.TabIndex = 15;
            this.btnInsert2.Text = "2";
            this.btnInsert2.UseVisualStyleBackColor = true;
            // 
            // btnInsert5
            // 
            this.btnInsert5.Location = new System.Drawing.Point(57, 102);
            this.btnInsert5.Name = "btnInsert5";
            this.btnInsert5.Size = new System.Drawing.Size(45, 45);
            this.btnInsert5.TabIndex = 14;
            this.btnInsert5.Text = "5";
            this.btnInsert5.UseVisualStyleBackColor = true;
            // 
            // btnInsert8
            // 
            this.btnInsert8.Location = new System.Drawing.Point(57, 51);
            this.btnInsert8.Name = "btnInsert8";
            this.btnInsert8.Size = new System.Drawing.Size(45, 45);
            this.btnInsert8.TabIndex = 13;
            this.btnInsert8.Text = "8";
            this.btnInsert8.UseVisualStyleBackColor = true;
            // 
            // btnInsert0
            // 
            this.btnInsert0.Location = new System.Drawing.Point(6, 206);
            this.btnInsert0.Name = "btnInsert0";
            this.btnInsert0.Size = new System.Drawing.Size(95, 45);
            this.btnInsert0.TabIndex = 12;
            this.btnInsert0.Text = "0";
            this.btnInsert0.UseVisualStyleBackColor = true;
            // 
            // btnInsert1
            // 
            this.btnInsert1.Location = new System.Drawing.Point(6, 153);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(45, 45);
            this.btnInsert1.TabIndex = 11;
            this.btnInsert1.Text = "1";
            this.btnInsert1.UseVisualStyleBackColor = true;
            // 
            // btnInsert4
            // 
            this.btnInsert4.Location = new System.Drawing.Point(6, 102);
            this.btnInsert4.Name = "btnInsert4";
            this.btnInsert4.Size = new System.Drawing.Size(45, 45);
            this.btnInsert4.TabIndex = 10;
            this.btnInsert4.Text = "4";
            this.btnInsert4.UseVisualStyleBackColor = true;
            // 
            // btnInsert7
            // 
            this.btnInsert7.Location = new System.Drawing.Point(6, 51);
            this.btnInsert7.Name = "btnInsert7";
            this.btnInsert7.Size = new System.Drawing.Size(45, 45);
            this.btnInsert7.TabIndex = 9;
            this.btnInsert7.Text = "7";
            this.btnInsert7.UseVisualStyleBackColor = true;
            // 
            // txtFormula
            // 
            this.txtFormula.Enabled = false;
            this.txtFormula.Location = new System.Drawing.Point(6, 22);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(373, 23);
            this.txtFormula.TabIndex = 0;
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(159, 51);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(45, 45);
            this.btnTimes.TabIndex = 8;
            this.btnTimes.Text = "X";
            this.btnTimes.UseVisualStyleBackColor = true;
            // 
            // SalesAndBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Controls.Add(this.panelCategories);
            this.Controls.Add(this.groupBox2);
            this.Name = "SalesAndBillingForm";
            this.Text = "Sales and Billing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlInvoice.ResumeLayout(false);
            this.tb_unos.ResumeLayout(false);
            this.tb_unos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControlInvoice;
        private TabPage tb_unos;
        private Label lblTotalPrice;
        private ListBox listBoxEntry;
        private Button btnDeleteInvoiceItem;
        private Button btnCheckout;
        private TabPage tabPage2;
        private Button btnSaveInvoice;
        private ListBox listBoxInvoice;
        private Label lbl_ukupna_cena;
        private Button btnNewTransaction;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private Panel panelCategories;
        private GroupBox groupBox2;
        private Button btnClearFormula;
        private Button btnDeleteFormulaCharacter;
        private Button btnEnter;
        private Button btnInsertComma;
        private Button btnInsert3;
        private Button btnInsert6;
        private Button btnInsert9;
        private Button btnInsert2;
        private Button btnInsert5;
        private Button btnInsert8;
        private Button btnInsert0;
        private Button btnInsert1;
        private Button btnInsert4;
        private Button btnInsert7;
        private TextBox txtFormula;
        private Button btnTimes;
        private Label lblTotalPriceText;
    }
}