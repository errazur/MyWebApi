namespace MyWebApi.Models;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Size { get; set; } // e.g., Small, Medium, Large
    public string[] Toppings { get; set; } // e.g., ["Pepperoni", "Mushrooms"]
    public bool IsVegetarian { get; set; }
    public bool IsGlutenFree { get; set; }
}