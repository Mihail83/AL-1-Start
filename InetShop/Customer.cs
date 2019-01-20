using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productTree;
using Payment;

namespace customerTree
{
    class Customer
    {
        public string name;        
        string email;               
        
        private int _idCustomer;
        public int IdCustomer
        {
            get
            {
                return _idCustomer;
            }
            set
            {
                _idCustomer = value;
            }
        }
        public Customer(string name)
        {
            this.name = name;
        }
    }

    class Basket
    {
        bool blockBasket;
        private Catalog catalogOfBasket;
        string nameOfCustomer;

        public Basket(Customer name)
        {
            nameOfCustomer = name.name;
        }

        public decimal SummuryBasket()
        {
            decimal sum = 0;
            foreach (var item in catalogOfBasket)
            {
                sum += item.Price;
            }
            return sum;
        }
        public void Add(params Product[] product)
        {
            if (this.blockBasket)
            {
                Console.WriteLine("Basket is blocked");                
            }
            else
            catalogOfBasket.AddProd(product);
        }

        public void remove(int id)
        {
            if (this.blockBasket)
            {
                Console.WriteLine("Basket is blocked");               
            }
            else
            catalogOfBasket.RemoveProd(id);
        }

        public void BlockBasket()
        { blockBasket = true; }

        public Purchase Buy()
        {
            return new Purchase(this);
        }
    }

    class Purchase
    {
        Basket basket;
        TypeOfPay typeOfPay;

        public Purchase(Basket basket)
        {
            this.basket = basket;
            basket.BlockBasket();
        }        
    }
}
