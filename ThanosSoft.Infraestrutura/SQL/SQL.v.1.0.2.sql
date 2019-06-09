USE [cuidaDB]
GO

/****** Object:  Table [dbo].[tbTiposDocumentos]    Script Date: 09/06/2019 08:58:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbTiposDocumentos](
	[codTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_tbTiposDocumentos] PRIMARY KEY CLUSTERED 
(
	[codTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbTiposDocumentos] ADD  CONSTRAINT [DF_tbTiposDocumentos_ativo]  DEFAULT ((1)) FOR [ativo]
GO


