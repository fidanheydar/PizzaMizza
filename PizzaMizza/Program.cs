
using PizzaMizza.Interfaces;
using PizzaMizza.Services;

PizzaService pizzaService = new PizzaService();

Console.WriteLine("Welcome to PizzaMizza !");
Console.WriteLine("1- Show the Pizzas");
Console.WriteLine("2- Add a Pizza");
Console.WriteLine("3- Exit ");

string choose=Console.ReadLine();
while (choose != "3")
{
    switch (choose)
    {
        case "1":
            pizzaService.Show();
            break;
        case "2":
            Pizza pizza = new Pizza();
            pizzaService.Create(pizza);
            break;
        default:
            Console.WriteLine("Please select the step number correctly !");
            break;
    }
    Console.WriteLine("1- Show the Pizzas");
    Console.WriteLine("2- Add a Pizza");
    Console.WriteLine("3- Exit ");

    choose = Console.ReadLine();
}
