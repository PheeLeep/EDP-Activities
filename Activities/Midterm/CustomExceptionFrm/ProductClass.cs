using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionFrm {
#pragma warning disable S2292

    public class ProductClass {
        private int _Quantity;
        private double _SellingPrice;

        private string _ProductName;
        private string _Description;
        private string _Category;
        private string _ManufacturingDate;
        private string _ExpirationDate;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate, 
                            double Price, int Quantity, string Description) {
            _Quantity = Quantity;
            _SellingPrice = Price;
            _ProductName = ProductName;
            _Description = Description;
            _Category = Category;
            _ManufacturingDate = MfgDate;
            _ExpirationDate = ExpDate;
            _Description = Description;
        }

        public string ProductName {
            get => _ProductName;
            set => _ProductName = value;
        }

        public string Category {
            get => _Category;
            set => _Category = value;   
        }

        public string ManufacturingDate {
            get=> _ManufacturingDate; 
            set => _ManufacturingDate = value;
        }

        public string ExpirationDate {
            get => _ExpirationDate;
            set => _ExpirationDate = value;
        }
        public string Description {
            get => _Description;
            set => _Description = value;
        }
        public int Quantity {
            get => _Quantity; 
            set => _Quantity = value;
        }

        public double SellingPrice {
            get => _SellingPrice;
            set => _SellingPrice = value;
        }
    }
}
