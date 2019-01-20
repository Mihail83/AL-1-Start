using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productTree
{
    class Catalog : IEnumerable<Product>
    {
        private List<Product> _catalog;

        public Catalog()
        {
            _catalog = new List<Product>();
        }

        public Product this[int index]
        {
            get { return _catalog[index]; }
            set {_catalog[index] = value; }
        }             

        public void SortBy()
        { }

        public void SearchBy()
        { }

        public void AddProd(params Product[] products)
        {
            _catalog.AddRange(products);  
        }

        public void RemoveProd(int idProd)   // встроенными методами????
        {
            Product i=null;
            foreach (var product in _catalog)
            {                
                if (product.CatalogNumber == idProd)
                {
                    i = product;
                }                
            }
            _catalog.Remove(i);
        }

        public IEnumerator<Product> GetEnumerator()    // автоматически
        {
            return ((IEnumerable<Product>)_catalog).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Product>)_catalog).GetEnumerator();
        }
    }
}
