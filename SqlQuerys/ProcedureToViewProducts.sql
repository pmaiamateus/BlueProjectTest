SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE or alter PROCEDURE ProcuraProdutosProcedure
	@filtro1 nvarchar(50) = null, 
	@filtro2 char(1) = null,
	@filtro3 int = null,
	@filtro4 nvarchar(3) = null,
	@itens int = null,
	@pagina int = null
AS
BEGIN
	if @filtro2 = 'N'
	SELECT top (@itens) Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Nome like @filtro1 and ProdutoId > @pagina
	if @filtro2 = 'D'
	SELECT top (@itens) Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Descricao like @filtro1 and ProdutoId > @pagina
	if @filtro4 = 'Min'
	SELECT top (@itens) Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Preco >= @filtro3 and ProdutoId > @pagina
	if @filtro4 = 'Max'
	SELECT top (@itens) Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Preco <= @filtro3 and ProdutoId > @pagina
	return;
END
go

