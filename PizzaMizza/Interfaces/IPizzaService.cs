using PizzaMizza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Interfaces
{
    public interface IPizzaService<Pizza> where Pizza:class
    {

        public void Create(Pizza pizza);

        public void Show();
    }
}
