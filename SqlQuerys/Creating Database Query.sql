CREATE DATABASE "TechStore"

create table TechStore.dbo.Produtos (
	ProdutoId int primary key IDENTITY(1,1),
	Nome varchar(100),
	Descricao varchar(255),
	Preco decimal(10,2),
	Estoque int,
	DataCadastro datetime)

Insert into TechStore.dbo.Produtos (Nome, Descricao, Preco, Estoque, DataCadastro)
Values ('motoedge20', 'smartphone da motorola', 500.00, 20, '20250527 22:22:22 PM')
Insert into TechStore.dbo.Produtos (Nome, Descricao, Preco, Estoque, DataCadastro)
Values ('GalaxyS25', 'smartphone da Samsung', 3000.00, 10, '20250527 22:22:25 PM')
Insert into TechStore.dbo.Produtos (Nome, Descricao, Preco, Estoque, DataCadastro)
Values ('Inspiron5', 'notebook da Dell', 5000.00, 15, '20250527 22:22:28 PM')
Insert into TechStore.dbo.Produtos (Nome, Descricao, Preco, Estoque, DataCadastro)
Values ('Iphone 15', 'smartphone da apple', 15000.00, 20, '20250527 22:25:00 PM')
Insert into TechStore.dbo.Produtos (Nome, Descricao, Preco, Estoque, DataCadastro)
Values ('hecate G4', 'fone de ouvido bluetooth', 350.00, 20, '20250527 22:27:00 PM')

