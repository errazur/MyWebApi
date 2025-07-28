using MyWebApi.Models;

namespace MyWebApi.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Margherita", Description = "Classic pizza with tomato sauce, mozzarella cheese, and fresh basil.", Price = 8.99m, Size = "Medium", Toppings = new[] { "Tomato Sauce", "Mozzarella Cheese", "Basil" }, IsVegetarian = true, IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Spicy pepperoni slices on a bed of mozzarella cheese.", Price = 9.99m, Size = "Large", Toppings = new[] { "Tomato Sauce", "Mozzarella Cheese", "Pepperoni" }, IsVegetarian = false, IsGlutenFree = false }
            // Add more pizzas as needed
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
            return;

        Pizzas[index] = pizza;
    }
}