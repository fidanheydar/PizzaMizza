using PizzaMizza.Core.Models;

namespace PizzaMizza.Services
{
    public class Pizza
    {
        private double _price;

        private static  int _count=0;
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public int Id { get; set; }
       
        public PizzaSize PizzaSize { get; set; }


        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }


        public Pizza()
        {
            _count++;
            Id = _count;
        }


        public override string ToString()
        {
            return $"Pizza Id:{Id}  Pizza Name:{Name} Pizza Price:{price}"; 
        }

    }
}