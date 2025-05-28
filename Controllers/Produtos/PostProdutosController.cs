using BlueProjectTest.Data;
using BlueProjectTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlueProjectTest.Controllers.Produtos;

public class PostProdutosController : Controller
{
    [AllowAnonymous]
    [HttpPost("produtos/")]
    public async Task<IActionResult> PostAsync(
        [FromBody] Produto ProdutoDoUsuario,
        [FromServices] AppDbContext context)
    {
        try
        {
            if (ModelState.IsValid)
            {
                Produto? produtoCheck = await context.Produtos.FirstOrDefaultAsync(p => p.Nome == ProdutoDoUsuario.Nome);
                if (produtoCheck == null)
                {
                    await context.Produtos.AddAsync(ProdutoDoUsuario);
                    await context.SaveChangesAsync();
                    return Created("produto criado", ProdutoDoUsuario);
                }
                return BadRequest("Produto ja cadastrado");
            }
            return BadRequest(ModelState);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}
