using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RetailSoft
{
    public class Products
    {
        public List<Product> ProductsList { get; set; }
        public double TotalPrice { get; set; } = 0;
    }
    public class Product
    {
        string price = "";
        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                int position = price.IndexOf("0");
                if (position == 0 || position == 1)
                {
                    price = price.Substring(position + 1);
                }
                price = Regex.Replace(price, @"\s+", "");
                if (quantity != "")
                {
                    Total = (double.Parse(quantity) * double.Parse(price)).ToString();                   
                }
            }
        }
        public string BarCode { get; set; } = "1";
        string quantity = "";
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                if (Price != "")
                {
                    Total = (double.Parse(quantity) * double.Parse(price)).ToString();
                }
            }
        }

        public string Description { get; set; }

        string total = "0";
        private string priceStr;

        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                CallBack(double.Parse(total));
            }
        }
        [JsonIgnore]
        [XmlIgnore]
        public Action<double> CallBack { get; set; }
    }
}
