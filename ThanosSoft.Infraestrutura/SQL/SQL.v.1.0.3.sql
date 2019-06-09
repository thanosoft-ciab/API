USE [cuidaDB]
GO

/****** Object:  Table [dbo].[tbUsuariosDocumentos]    Script Date: 09/06/2019 08:58:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbUsuariosDocumentos](
	[codUsuario] [int] NOT NULL,
	[codTipoDocumento] [int] NOT NULL,
	[arquivo] [binary](50) NULL,
	[tipoArquivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbUsuariosDocumentos] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC,
	[codTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbUsuariosDocumentos]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuariosDocumentos_tbTiposDocumentos] FOREIGN KEY([codTipoDocumento])
REFERENCES [dbo].[tbTiposDocumentos] ([codTipoDocumento])
GO

ALTER TABLE [dbo].[tbUsuariosDocumentos] CHECK CONSTRAINT [FK_tbUsuariosDocumentos_tbTiposDocumentos]
GO

ALTER TABLE [dbo].[tbUsuariosDocumentos]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuariosDocumentos_tbUsuarios] FOREIGN KEY([codUsuario])
REFERENCES [dbo].[tbUsuarios] ([codUsuario])
GO

ALTER TABLE [dbo].[tbUsuariosDocumentos] CHECK CONSTRAINT [FK_tbUsuariosDocumentos_tbUsuarios]
GO


