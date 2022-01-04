namespace Way2Commerce.Domain.Entities;

public class Product
{
    public Product(int id, string code, string name, string description, decimal price, int categoryId)
    {
        Id = id;
        Code = code;
        Name = name;
        Description = description;
        Price = price;
        CreatedDate = DateTime.Now; //TODO: Add abstration
        CategoryId = categoryId;
    }

    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime  CreatedDate { get; set; }
    public int CategoryId { get; set; } //TODO: Maybe use complex entity

    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(Code) | Code.Length > 6)
        {
            return false;
        }

        return true;
    }
}