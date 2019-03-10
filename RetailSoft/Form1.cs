using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Newtonsoft.Json;

namespace RetailSoft
{
    public partial class Form1 : Form
    {
        #region Properties
        public Products Products { get; set; } = new Products();
        public Dictionary<string, bool> AllBarCods { get; set; } = new Dictionary<string, bool>();
        #endregion
        bool byCode = true;
        public Form1()
        {
            InitializeComponent();
        }

        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            Products.ProductsList = new List<Product>();
            quantityTextBox.Text = "1";
            byCode = true;
            priceTextBox.Text = "₪ 0";
            TotalPriceTxtBox.Text = "₪ 0";
            //string str = 0.ToString("c", CultureInfo.CreateSpecificCulture("en-NIS"));
        }
        private void updatePrice_Click(object sender, EventArgs e)
        {
            ObjectListView ProductsTable = Controls.Find("ProductsTable", true).FirstOrDefault() as ObjectListView;
            string errosMsg;
            if (CheckIfAllTxtIsValid(out errosMsg))
            {
                AllBarCods.Add(codeTextBox.Text, true);
                int position = priceTextBox.Text.IndexOf("₪ 0");
                string priceStr = priceTextBox.Text.Substring(position + 2);
                Product tempProduct = new Product
                {
                    CallBack = UpdateTotal,
                    Price = priceStr,
                    BarCode = codeTextBox.Text,
                    Quantity = quantityTextBox.Text,
                    Description = descriptionTextBox.Text,

                };
                Products.ProductsList.Add(tempProduct);
                this.ProductsTable.SetObjects(Products.ProductsList);
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show(":לא ניתן להוסיף מוצר בגלל הסיבות הבאות\n" + errosMsg);
            }
        }
        private void TotalPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }  
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (byCode)
            {
                byCode = false;
                return;
            }
            TextBox txtTextBox = sender as TextBox;
            string txt = txtTextBox.Text;
            int position = priceTextBox.Text.IndexOf("₪");
            string priceStr =priceTextBox.Text.Substring(position + 1);
            if(position ==1)
            {
                char addChar = priceTextBox.Text[0];
                priceStr = addChar.ToString() + priceStr;
            }
            priceStr = Regex.Replace(priceStr, @"\s+", "");
            priceStr = "₪ " + priceStr;
            if (priceStr == "₪ ")
            {
                priceStr = priceStr + "0";
            }
            if (txtTextBox.Text != priceStr)
            {
                byCode = true;
            }
            txtTextBox.Text = priceStr;

        }
        private void ProductsTable_CellEditStarting(object sender, CellEditEventArgs e)
        {
            BrightIdeasSoftware.CellEditEventArgs _event_ = e as BrightIdeasSoftware.CellEditEventArgs;
            if (!(e.Column.AspectName == "Price" || e.Column.AspectName == "Quantity"))
            {
                e.Cancel = true;
            }
            return;
        }
        private void ProductsTable_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            BrightIdeasSoftware.CellEditEventArgs _event_ = e as BrightIdeasSoftware.CellEditEventArgs;
            if (!(e.Column.AspectName == "Price" || e.Column.AspectName == "Quantity"))
            {
                e.Cancel = true;
                return;
            }
            else if (e.Column.AspectName == "Price")
            {
                if (!(double.TryParse(_event_.NewValue.ToString(), out double d) && !Double.IsNaN(d) && !Double.IsInfinity(d)))
                {
                    e.Cancel = true;
                    return;
                }
            }
            else if (e.Column.AspectName == "Quantity")
            {
                int x;
                if (!(int.TryParse(_event_.NewValue.ToString(), out x) && x > 0))
                {
                    e.Cancel = true;
                    return;
                }
            }
            Product curr = _event_.RowObject as Product;
            int currentChangingIdx = Products.ProductsList.FindIndex(p => p.BarCode == curr.BarCode);
            double decreasePrice = double.Parse(Products.ProductsList[currentChangingIdx].Total);
            //double totalPrice = double.Parse(Products.TotalPrice);
            Products.TotalPrice -= decreasePrice;
            //Products.TotalPrice = totalPrice.ToString();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9]"))
            {
                e.Handled = true;
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void jsonExport_Click(object sender, EventArgs e)
        {
            var path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + "\\exportFolder\\SerializationProducts.json";
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, Products);
            }
        }
        private void XmlExport_Click(object sender, EventArgs e)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Products));

                var path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + "\\exportFolder\\SerializationProducts.xml";
                System.IO.FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, Products);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("לא ניתן ליצור קובץ מהסיבות הבאות:\n" + ex.Message);
            }
        }


        #endregion

        #region functions
        public void UpdateTotal(double total)
        {
            Products.TotalPrice += total;
            TotalPriceTxtBox.Text = "₪ " + Products.TotalPrice.ToString();
        }
        private void ClearTextBoxs()
        {
            codeTextBox.Text = "";
            descriptionTextBox.Text = "";
            quantityTextBox.Text = "1";
            byCode = true;
            priceTextBox.Text = "₪ 0";
        }


        private bool CheckIfAllTxtIsValid(out string errosMsg)
        {
            errosMsg = "";
            if (codeTextBox.Text == "")
            {
                errosMsg += "בבקשה הכנס קוד למוצר" + "\n";
            }
            else
            {
                if (AllBarCods.ContainsKey(codeTextBox.Text))
                {
                    errosMsg += "קוד קיים, בבקשה בחר קוד שונה למוצר"+"\n";
                }
            }
            if (descriptionTextBox.Text == "")
            {
                errosMsg +=  "בבקשה הכנס תיאור למוצר " + "\n";
            }
            if (quantityTextBox.Text == "")
            {
                errosMsg +=  "בבקשה הכנס כמות למוצר" + "\n";
            }
            if (priceTextBox.Text == "₪ 0")
            {
                errosMsg += "בבקשה הכנס מחיר למוצר" +"\n";
            }
            if (errosMsg == "")
            {
                return true;
            }
            return false;
        }




        #endregion


    }


}
