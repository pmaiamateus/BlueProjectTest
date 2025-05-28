using BlueProjectTest.Data;
using BlueProjectTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BlueProjectTest.Controllers.Produtos;

public class GetProdutosController : Controller
{
    [AllowAnonymous]
    [HttpGet("/produtos/{filtro1}+{filtro2}+{filtro3:int}+{filtro4}+{itens:int}+{pagina:int}")]
    public async Task<List<Produto>> GetAsync(
        [FromRoute] string? filtro1, char? filtro2, int? filtro3, string? filtro4, int itens, int pagina,
        [FromServices] AppDbContext context)
    {
        return await context.Produtos
                     .FromSqlRaw($"DECLARE @return_value int EXEC @return_value = [TechStore].[dbo].[ProcuraProdutosProcedure] @Filtro1,@Filtro2,@Filtro3,@Filtro4,@itens,@pagina SELECT 'Return Value' = @return_value", new object[] { new SqlParameter("@Filtro1", filtro1), new SqlParameter("@Filtro2", filtro2), new SqlParameter("@Filtro3", filtro3), new SqlParameter("@Filtro4", filtro4), new SqlParameter("@itens", itens), new SqlParameter("@pagina", pagina) })
                     .ToListAsync();
    }

}