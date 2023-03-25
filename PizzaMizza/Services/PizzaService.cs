using PizzaMizza.Core.Models;
using PizzaMizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
    internal class PizzaService : IPizzaService<Pizza>
    {

     List<Pizza> pizzaList=new List<Pizza>();
        List<PizzaIngredients> pizzaIngredients = new List<PizzaIngredients>();
        public void Create(Pizza pizza)
        {
            Console.WriteLine("Enter the pizza name:");
            pizza.Name=Console.ReadLine();




            bool status=false;

            while( !status)
            {
                Console.WriteLine($"1: {PizzaSize.Small}");
                Console.WriteLine($"2: {PizzaSize.Medium}");
                Console.WriteLine($"3: {PizzaSize.Large}");
                int request = int.Parse(Console.ReadLine());


                switch (request)
                {
                    case 1:
                        pizza.PizzaSize = PizzaSize.Small;
                            status = true;
                        break;

                        case 2:
                        pizza.PizzaSize=PizzaSize.Medium;
                        status = true;  
                        break;

                        case 3:
                        pizza.PizzaSize= PizzaSize.Large;
                        status = true;
                        break;

                        default: Console.WriteLine("Select step correctly");
                        break;



                }


            }


            Console.WriteLine("Press E for extras");
            Console.WriteLine("Press C for countinue");
            string extras = Console.ReadLine();
            if(extras != "C") 
            { 
            
            switch( extras )
                {
                    case "E":
                        Console.WriteLine("Select extra ingredients");
                        Console.WriteLine($"1:{PizzaIngredients.Tomato}");
                        Console.WriteLine($"2:{PizzaIngredients.Mushroom}");
                        Console.WriteLine($"3:{PizzaIngredients.Olive}");

                        string extrarequest= Console.ReadLine();
                        

                    while( extrarequest != "q")
                        {
                            switch (extrarequest)
                            {
                                case "1":
                                    pizzaIngredients.Add((pizzaIngredients)PizzaIngredients.Olive);
                            
                                        break;

                                case "2":
                                    pizzaIngredients.Add((pizzaIngredients)PizzaIngredients.Tomato);
                                    break;

                                    case "3":
                                    pizzaIngredients.Add((pizzaIngredients)PizzaIngredients.Mushroom); break;

                                default:
                                    Console.WriteLine("Select only 1-3") ;
                                    break;
                                   
                            }
                            Console.WriteLine($"1:{PizzaIngredients.Tomato}");
                            Console.WriteLine($"2:{PizzaIngredients.Mushroom}");
                            Console.WriteLine($"3:{PizzaIngredients.Olive}");
                            extrarequest= Console.ReadLine();
                        }
                        break;


                }
            }
            Console.WriteLine("Select Pizza Price");
            pizza.price=double.Parse( Console.ReadLine() );
            pizzaList.Add( pizza);


        }

       



        public void Show()
        {
            if(pizzaList.Count > 0)
            {
                foreach (var item in pizzaList) 
                {
                    Console.WriteLine(item);
                }
                ShowById(GetPizzaIngredients());
            }
            else
            {
                Console.WriteLine("Add a Pizza");
            }
        }

        public List<PizzaIngredients> GetPizzaIngredients()
        {
            return pizzaIngredients;
        }

        public void ShowById(List<PizzaIngredients> pizzaIngredients)
        {
            Console.WriteLine("Enter Pizza Id number");
            int id=int.Parse(Console.ReadLine());
            for(int i = 0; i < pizzaList.Count; i++)
            {
                if (pizzaList[i].Id == id)
                {
                    for(int j=0; pizzaIngredients.Count;j++)
                    {
                        Console.WriteLine($"Add extra ingredients:{(PizzaIngredients)pizzaIngredients[j]}");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Id number");
                }
               
            }
        }

       

       
    }
}