using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models;


public class Pizza
{
    public List<Pizza> pizzas = new();
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public PizzaSize Size { get; set; }
    public bool IsGlutenFree { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

public enum PizzaSize { Small, Medium, Large }