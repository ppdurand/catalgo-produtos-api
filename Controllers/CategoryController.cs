using Microsoft.AspNetCore.Mvc;

namespace catalogo.produtos.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public string ListCategory()
    {
        return "Listar Categorias";
    }

    [HttpPost]
    public string CreateCategory() 
    {
        return "Criar categoria";
    }
}