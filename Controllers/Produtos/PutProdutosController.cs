using BlueProjectTest.Data;
using BlueProjectTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlueProjectTest.Controllers.Produtos;

public class PutProdutosController : Controller
{
    [AllowAnonymous]
    [HttpPut("produtos/{id:int}")]
    public async Task<IActionResult> PutAsync(
		[FromRoute] int id,
		[FromBody] Produto produtoAtualizar,
		[FromServices] AppDbContext context
		)
    {
		try
		{
			if (ModelState.IsValid)
			{
				Produto? produtoDb = await context.Produtos.FirstOrDefaultAsync(p => p.ProdutoId == id);
				if (produtoDb == null)
					return NotFound();
				produtoDb.Nome = produtoAtualizar.Nome;
				produtoDb.Descricao = produtoAtualizar.Descricao;
				produtoDb.Preco = produtoAtualizar.Preco;
				produtoDb.Estoque = produtoAtualizar.Estoque;
				context.Update(produtoDb);
				await context.SaveChangesAsync();
				return Ok("Atualizado");
			}
			return BadRequest(produtoAtualizar);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
			return BadRequest("erro");
		}
    }
}
