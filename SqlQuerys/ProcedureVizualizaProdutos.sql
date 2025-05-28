SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE or alter PROCEDURE ProcuraProdutosProcedure
	@filtro1 nvarchar(50) = null, -- usar % antes ou depois do item para pesquisar se o nome ou descri��o cont�m o digitado
	@filtro2 char(1) = null, -- N para pesquisar por nome, D para pesquisar por descricao
	@filtro3 int = null,
	@filtro4 nvarchar(3) = null, -- Min para pesquisar por minimo, Max para pesquisar por maximo
	@itens int = null, -- itens por p�gina
	@pagina int = null -- n�mero da p�gina
AS
BEGIN
	if @filtro2 = 'N'
	SELECT top (@itens) [ProdutoId], Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Nome like @filtro1 and ProdutoId > @pagina
	if @filtro2 = 'D'
	SELECT top (@itens) [ProdutoId], Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Descricao like @filtro1 and ProdutoId > @pagina
	if @filtro4 = 'Min'
	SELECT top (@itens) [ProdutoId], Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Preco >= @filtro3 and ProdutoId > @pagina
	if @filtro4 = 'Max'
	SELECT top (@itens) [ProdutoId], Nome, Descricao, preco, estoque, datacadastro
	from dbo.Produtos
	where Preco <= @filtro3 and ProdutoId > @pagina
	return;
END
go

