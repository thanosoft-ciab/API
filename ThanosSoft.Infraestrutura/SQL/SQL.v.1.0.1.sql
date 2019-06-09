USE [cuidaDB]
GO

/****** Object:  Table [dbo].[tbUsuarios]    Script Date: 09/06/2019 08:58:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbUsuarios](
	[codUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NULL,
	[sobrenome] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[rg] [nvarchar](50) NULL,
	[cpf] [nvarchar](50) NULL,
	[cnh] [nvarchar](50) NULL,
	[tipocnh] [nvarchar](50) NULL,
	[dataNascimento] [datetime] NULL,
	[sexo] [char](1) NULL,
	[estadoCivil] [nvarchar](50) NULL,
	[nomePai] [nvarchar](50) NULL,
	[nomeMae] [nvarchar](50) NULL,
	[cartaoCidadao] [nvarchar](50) NULL,
	[cartaoSus] [nvarchar](50) NULL,
	[carteiraTrabalhoNumero] [nvarchar](50) NULL,
	[certidaoNascimento] [nvarchar](50) NULL,
	[certidaoCasamento] [nvarchar](50) NULL,
	[conjuge] [nvarchar](50) NULL,
	[cpfConjuge] [nvarchar](50) NULL,
	[rgConjuge] [nvarchar](50) NULL,
	[endereco] [nvarchar](50) NULL,
	[bairro] [nvarchar](50) NULL,
	[cidade] [nvarchar](50) NULL,
	[estado] [char](2) NULL,
	[senha] [nvarchar](max) NULL,
	[tipoCadastro] [int] NULL,
	[dataCadastro] [datetime] NULL,
	[dataUltimaAtualizacao] [datetime] NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_tbUsuarios] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbUsuarios] ADD  CONSTRAINT [DF_tbUsuarios_ativo]  DEFAULT ((1)) FOR [ativo]
GO


