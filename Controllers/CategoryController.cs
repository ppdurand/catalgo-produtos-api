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

    [HttpDelete]
    public string DeleteCatgeory(int Id)
    {
        return "Deletando categoria";
    }

    [HttpPut]
    public string UpdateCategory()
    {
        return "Atualizar categoria";
    }
}