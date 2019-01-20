using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace productTree
{
    public abstract class Product
    {
        protected string name;
        protected string info;

        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    _price = 0m;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public int CatalogNumber { get; private set; }
        
        public Product(string name, decimal price, int catNumber, string info)
        {
            this.name = name;
            Price = price;
            CatalogNumber = catNumber;
            this.info = info;
        }

        //      A.L1.P6/6
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool operator ==(Product pr1, Product pr2) => pr1.Price == pr2.Price;
        public static bool operator !=(Product pr1, Product pr2) => pr1.Price != pr2.Price;

        public static bool operator >(Product pr1, Product pr2) => pr1.Price > pr2.Price;
        public static bool operator <(Product pr1, Product pr2) => pr1.Price < pr2.Price;

        public override bool Equals(object obj)
        {
            var product = obj as Product;   
            return base.Equals(product);
        }       

        public override int GetHashCode()
        {
            return 0;
        }
    }

    public class AppliancesProduct : Product
    {
        int power;        
        public AppliancesProduct(string name, decimal price, int catNumber, int power, string info) : base(name, price, catNumber, info)
        {
            this.power = power;            
        }
        public override string ToString()
        {
            return $"  Название:  {name}  Цена:  {Price} Номер: {CatalogNumber}  \n Мощность: {power}  Информация:  {info} ";
        }
    }

    public class SportProduct : Product
    {
        float height;   //рост
        int size;

        public SportProduct(string name, decimal price, int catNumber, string info, float heigth, int size) : base(name, price, catNumber, info)
        {
            this.height = heigth;
            this.size = size;            
        }

        public override string ToString()
        {
            return $"  Название:  {name}  Цена:  {Price} Номер: {CatalogNumber}  \n Рост: {height} размер: {size}  Информация:  {info} ";
        }
    }




}
