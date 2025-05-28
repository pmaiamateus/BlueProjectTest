using BlueProjectTest.Data;
using BlueProjectTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlueProjectTest.Controllers.Produtos;

public class DeleteProdutosController : Controller
{
    [AllowAnonymous]
    [HttpDelete("produtos/{id:int}")]
    public async Task<IActionResult> DeleteAsync(
		[FromRoute] int id,
		[FromServices] AppDbContext context)
    {
		try
		{
            Produto? procuraProduto = await context.Produtos.FirstOrDefaultAsync(u => u.ProdutoId == id);
			if (procuraProduto == null)
				return NotFound();
			context.Remove(procuraProduto);
			context.SaveChanges();
            return Ok();
		}
		catch (Exception)
		{
			throw;
		}
    }
}
