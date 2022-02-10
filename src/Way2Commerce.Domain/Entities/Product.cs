using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Way2Commerce.Domain.Entities;

public class Product
{
    public Product(int id,
                   string code,
                   string name,
                   string description,
                   decimal price,
                   Category category,
                   bool active = true)
    {
        Id = id;
        Code = code;
        Name = name;
        Description = description;
        Price = price;
        CreatedDate = DateTime.UtcNow; //TODO: Add abstration
        Category = category;
        Active = active;
    }

    public int Id { get; private set; }
    public string Code { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public Category Category { get; private set; }
    public bool Active { get; private set; }

    public void SetDeactivate()
    {
        Active = false;
    }

    public void PopuleValues(Product product)
    {
        this.Code = product.Code;
        this.Name = product.Name;
        this.Description = product.Description;
        this.Price = product.Price;
        this.Category = product.Category;
    }

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