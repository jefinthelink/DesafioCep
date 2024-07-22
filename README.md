# DesafioCep

Para alterar a string de conexão com o banco de dados, acesso moduleBanco. 

stringConexao = "Data Source=(localDB)\SSGP; Integrated Security=False; Initial Catalog=db_banco; User ID=Keye; PassWord=123456"



Tabela criado no banco de dados sqlserver

CREATE TABLE [dbo].[cep_endereco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cep] [nchar](50) NULL,
	[logradouro] [nchar](50) NULL,
	[bairro] [nchar](50) NULL,
	[cidade] [nchar](50) NULL,
	[uf] [nchar](50) NULL,
 CONSTRAINT [PK_cep_endereco] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



