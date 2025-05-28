create view ProcuraProdutos as
SELECT       top 3 Nome, Descricao, Preco, Estoque, DataCadastro
FROM         dbo.Produtos
WHERE        (Nome LIKE 'Filtro1') OR
             (Descricao LIKE 'Filtro2') OR
             (Preco > 10) OR
             (Preco < 5) and
			 (ProdutoId > 3)
order by ProdutoId
	-- use filtro1, filtro2 ou o valor apos Preco para filtrar os produtos de maneira opcional
	-- para paginar use o parametro após o top para o numero de itens na pagina e o parametro apos ProdutoId para o primeiro item da pagina