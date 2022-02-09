using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Way2Commerce.Domain.Entities;

public class Product
{
    public Product(int id, string code, string name, string description, decimal price, Category category)
    {
        Id = id;
        Code = code;
        Name = name;
        Description = description;
        Price = price;
        CreatedDate = DateTime.UtcNow; //TODO: Add abstration
        Category = category;
    }

    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public Category Category { get; set; } //TODO: Maybe use complex entity

    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(Code) | Code.Length > 6)
        {
            return false;
        }

        return true;
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Category
{
    [EnumMember(Value = "Indefinido")]
    None = 0,
    [EnumMember(Value = "Eletronicos")]
    Eletronics,
    [EnumMember(Value = "Arte & Craft")]
    ArtAndCraft
}