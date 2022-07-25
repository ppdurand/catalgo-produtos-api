namespace catalogo.produtos.api.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public string? Initials { get; set; }
    public bool isActivite { get; set; }
    public DateTime RegistrationDate { get; set; }
}