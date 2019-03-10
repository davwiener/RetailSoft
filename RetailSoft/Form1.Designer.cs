
namespace RetailSoft
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.peiceLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.updatePrice = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.ProductsTable = new BrightIdeasSoftware.ObjectListView();
            this.Total = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Quantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Price = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BarCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.XmlExport = new System.Windows.Forms.Button();
            this.jsonExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "הוספת פריט";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.peiceLabel);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.updatePrice);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.codeTextBox);
            this.panel1.Location = new System.Drawing.Point(465, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 200);
            this.panel1.TabIndex = 25;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(144, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionLabel.Size = new System.Drawing.Size(44, 13);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "תיאור :";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 50);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(129, 20);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // peiceLabel
            // 
            this.peiceLabel.AutoSize = true;
            this.peiceLabel.Location = new System.Drawing.Point(147, 107);
            this.peiceLabel.Name = "peiceLabel";
            this.peiceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.peiceLabel.Size = new System.Drawing.Size(38, 13);
            this.peiceLabel.TabIndex = 18;
            this.peiceLabel.Text = "מחיר :";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(14, 76);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(129, 20);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // updatePrice
            // 
            this.updatePrice.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatePrice.Location = new System.Drawing.Point(14, 143);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.updatePrice.Size = new System.Drawing.Size(166, 32);
            this.updatePrice.TabIndex = 5;
            this.updatePrice.Text = "הוסף שורה";
            this.updatePrice.UseVisualStyleBackColor = false;
            this.updatePrice.Click += new System.EventHandler(this.updatePrice_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(149, 81);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantityLabel.Size = new System.Drawing.Size(39, 13);
            this.quantityLabel.TabIndex = 15;
            this.quantityLabel.Text = "כמות :";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(14, 102);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(129, 20);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(153, 29);
            this.code.Name = "code";
            this.code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.code.Size = new System.Drawing.Size(32, 13);
            this.code.TabIndex = 13;
            this.code.Text = "קוד :";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(14, 24);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(129, 20);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductsTable
            // 
            this.ProductsTable.AllColumns.Add(this.Total);
            this.ProductsTable.AllColumns.Add(this.Quantity);
            this.ProductsTable.AllColumns.Add(this.Price);
            this.ProductsTable.AllColumns.Add(this.Description);
            this.ProductsTable.AllColumns.Add(this.BarCode);
            this.ProductsTable.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.ProductsTable.CellEditEnterChangesRows = true;
            this.ProductsTable.CellEditTabChangesRows = true;
            this.ProductsTable.CellEditUseWholeCell = false;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Total,
            this.Quantity,
            this.Price,
            this.Description,
            this.BarCode});
            this.ProductsTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductsTable.GridLines = true;
            this.ProductsTable.HasCollapsibleGroups = false;
            this.ProductsTable.HeaderMinimumHeight = 10;
            this.ProductsTable.HeaderWordWrap = true;
            this.ProductsTable.Location = new System.Drawing.Point(25, 23);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ShowGroups = false;
            this.ProductsTable.Size = new System.Drawing.Size(387, 448);
            this.ProductsTable.TabIndex = 9;
            this.ProductsTable.UseCompatibleStateImageBehavior = false;
            this.ProductsTable.View = System.Windows.Forms.View.Details;
            this.ProductsTable.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.ProductsTable_CellEditFinishing);
            this.ProductsTable.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.ProductsTable_CellEditStarting);
            // 
            // Total
            // 
            this.Total.AspectName = "Total";
            this.Total.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Text = "סה\"כ לשורה";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Width = 102;
            // 
            // Quantity
            // 
            this.Quantity.AspectName = "Quantity";
            this.Quantity.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Text = "כמות";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 79;
            // 
            // Price
            // 
            this.Price.AspectName = "Price";
            this.Price.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Text = "מחיר";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description
            // 
            this.Description.AspectName = "Description";
            this.Description.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Text = "תיאור";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarCode
            // 
            this.BarCode.AspectName = "BarCode";
            this.BarCode.CellEditUseWholeCell = false;
            this.BarCode.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarCode.Text = "קוד";
            this.BarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarCode.Width = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 29;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 502);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "סה\"כ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPriceTxtBox
            // 
            this.TotalPriceTxtBox.Location = new System.Drawing.Point(44, 499);
            this.TotalPriceTxtBox.Name = "TotalPriceTxtBox";
            this.TotalPriceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPriceTxtBox.TabIndex = 8;
            this.TotalPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalPriceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalPriceTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 4);
            this.label3.TabIndex = 32;
            // 
            // XmlExport
            // 
            this.XmlExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.XmlExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XmlExport.Location = new System.Drawing.Point(479, 405);
            this.XmlExport.Name = "XmlExport";
            this.XmlExport.Size = new System.Drawing.Size(168, 32);
            this.XmlExport.TabIndex = 7;
            this.XmlExport.Text = "XML יצוא";
            this.XmlExport.UseVisualStyleBackColor = false;
            this.XmlExport.Click += new System.EventHandler(this.XmlExport_Click);
            // 
            // jsonExport
            // 
            this.jsonExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.jsonExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jsonExport.Location = new System.Drawing.Point(479, 367);
            this.jsonExport.Name = "jsonExport";
            this.jsonExport.Size = new System.Drawing.Size(168, 32);
            this.jsonExport.TabIndex = 6;
            this.jsonExport.Text = "JSON יצוא";
            this.jsonExport.UseVisualStyleBackColor = false;
            this.jsonExport.Click += new System.EventHandler(this.jsonExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(727, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalPriceTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jsonExport);
            this.Controls.Add(this.XmlExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label peiceLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button updatePrice;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox codeTextBox;
        private BrightIdeasSoftware.ObjectListView ProductsTable;
        private BrightIdeasSoftware.OLVColumn Total;
        private BrightIdeasSoftware.OLVColumn Quantity;
        private BrightIdeasSoftware.OLVColumn Price;
        private BrightIdeasSoftware.OLVColumn Description;
        private BrightIdeasSoftware.OLVColumn BarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalPriceTxtBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button XmlExport;
        private System.Windows.Forms.Button jsonExport;
    }
}

