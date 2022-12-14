USE [AaDb]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 20.06.2021 21:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[id_author] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[second_name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[id_author] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bibliotekar]    Script Date: 20.06.2021 21:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bibliotekar](
	[id_bibliotekaria] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[second_name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[tel] [nvarchar](50) NULL,
	[adress] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bibliotekar] PRIMARY KEY CLUSTERED 
(
	[id_bibliotekaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitatel]    Script Date: 20.06.2021 21:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitatel](
	[id_chitatelia] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[second_name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[seria_i_number_pasp] [nvarchar](50) NULL,
	[adress] [nvarchar](50) NULL,
	[tel] [nvarchar](50) NULL,
 CONSTRAINT [PK_Chitatel] PRIMARY KEY CLUSTERED 
(
	[id_chitatelia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formular]    Script Date: 20.06.2021 21:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formular](
	[id_formular] [int] IDENTITY(1,1) NOT NULL,
	[id_chitatelia] [int] NOT NULL,
	[id_knigi] [int] NOT NULL,
	[id_vidachi] [int] NOT NULL,
	[id_vozvrata] [int] NOT NULL,
	[srok_vozvrata] [nvarchar](50) NULL,
	[inventarnii_number] [nvarchar](50) NULL,
	[author] [nvarchar](50) NULL,
	[zaglavie] [nvarchar](50) NULL,
 CONSTRAINT [PK_Formular] PRIMARY KEY CLUSTERED 
(
	[id_formular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izdatelstvo]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izdatelstvo](
	[id_izdatelstva] [int] IDENTITY(1,1) NOT NULL,
	[nazvanie] [nvarchar](50) NULL,
	[mesto_izdania] [nvarchar](50) NULL,
	[year_izdania] [nvarchar](50) NULL,
 CONSTRAINT [PK_Izdatelstvo] PRIMARY KEY CLUSTERED 
(
	[id_izdatelstva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kniga]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kniga](
	[id_knigi] [int] IDENTITY(1,1) NOT NULL,
	[id_izdatelstva] [int] NOT NULL,
	[id_type_izdania] [int] NOT NULL,
	[id_author] [int] NOT NULL,
	[zaglavie] [nvarchar](50) NULL,
	[inventarnii_number] [nvarchar](50) NULL,
	[kol_str] [nvarchar](50) NULL,
	[bbk_index] [nvarchar](50) NULL,
	[ubk_index] [nvarchar](50) NULL,
	[nalichie] [bit] NULL,
 CONSTRAINT [PK_Kniga] PRIMARY KEY CLUSTERED 
(
	[id_knigi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[id_roli] [int] IDENTITY(1,1) NOT NULL,
	[naimenovanie] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id_roli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_izdania]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_izdania](
	[id_type_izdania] [int] IDENTITY(1,1) NOT NULL,
	[type_izdania] [nvarchar](50) NULL,
 CONSTRAINT [PK_Type_izdania] PRIMARY KEY CLUSTERED 
(
	[id_type_izdania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id_bibliotekaria] [int] NOT NULL,
	[id_roli] [int] NOT NULL,
	[login] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vidacha]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vidacha](
	[id_vidachi] [int] IDENTITY(1,1) NOT NULL,
	[id_knigi] [int] NOT NULL,
	[id_chitatelia] [int] NOT NULL,
	[id_bibliotekaria] [int] NOT NULL,
	[date_vidachi] [nvarchar](50) NULL,
	[srok_vidachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Vidacha] PRIMARY KEY CLUSTERED 
(
	[id_vidachi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vozvrat]    Script Date: 20.06.2021 21:06:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vozvrat](
	[id_vozvrata] [int] IDENTITY(1,1) NOT NULL,
	[id_knigi] [int] NOT NULL,
	[id_chitatelia] [int] NOT NULL,
	[id_bibliotekaria] [int] NOT NULL,
	[date_vozvrata] [date] NULL,
	[sdano] [bit] NULL,
 CONSTRAINT [PK_Vozvrat] PRIMARY KEY CLUSTERED 
(
	[id_vozvrata] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Formular]  WITH CHECK ADD  CONSTRAINT [FK_Formular_Chitatel] FOREIGN KEY([id_chitatelia])
REFERENCES [dbo].[Chitatel] ([id_chitatelia])
GO
ALTER TABLE [dbo].[Formular] CHECK CONSTRAINT [FK_Formular_Chitatel]
GO
ALTER TABLE [dbo].[Formular]  WITH CHECK ADD  CONSTRAINT [FK_Formular_Kniga] FOREIGN KEY([id_knigi])
REFERENCES [dbo].[Kniga] ([id_knigi])
GO
ALTER TABLE [dbo].[Formular] CHECK CONSTRAINT [FK_Formular_Kniga]
GO
ALTER TABLE [dbo].[Formular]  WITH CHECK ADD  CONSTRAINT [FK_Formular_Vidacha] FOREIGN KEY([id_vidachi])
REFERENCES [dbo].[Vidacha] ([id_vidachi])
GO
ALTER TABLE [dbo].[Formular] CHECK CONSTRAINT [FK_Formular_Vidacha]
GO
ALTER TABLE [dbo].[Formular]  WITH CHECK ADD  CONSTRAINT [FK_Formular_Vozvrat] FOREIGN KEY([id_vozvrata])
REFERENCES [dbo].[Vozvrat] ([id_vozvrata])
GO
ALTER TABLE [dbo].[Formular] CHECK CONSTRAINT [FK_Formular_Vozvrat]
GO
ALTER TABLE [dbo].[Kniga]  WITH CHECK ADD  CONSTRAINT [FK_Kniga_Author] FOREIGN KEY([id_author])
REFERENCES [dbo].[Author] ([id_author])
GO
ALTER TABLE [dbo].[Kniga] CHECK CONSTRAINT [FK_Kniga_Author]
GO
ALTER TABLE [dbo].[Kniga]  WITH CHECK ADD  CONSTRAINT [FK_Kniga_Izdatelstvo] FOREIGN KEY([id_izdatelstva])
REFERENCES [dbo].[Izdatelstvo] ([id_izdatelstva])
GO
ALTER TABLE [dbo].[Kniga] CHECK CONSTRAINT [FK_Kniga_Izdatelstvo]
GO
ALTER TABLE [dbo].[Kniga]  WITH CHECK ADD  CONSTRAINT [FK_Kniga_Type_izdania] FOREIGN KEY([id_type_izdania])
REFERENCES [dbo].[Type_izdania] ([id_type_izdania])
GO
ALTER TABLE [dbo].[Kniga] CHECK CONSTRAINT [FK_Kniga_Type_izdania]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Bibliotekar] FOREIGN KEY([id_bibliotekaria])
REFERENCES [dbo].[Bibliotekar] ([id_bibliotekaria])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Bibliotekar]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Rol] FOREIGN KEY([id_roli])
REFERENCES [dbo].[Rol] ([id_roli])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Rol]
GO
ALTER TABLE [dbo].[Vidacha]  WITH CHECK ADD  CONSTRAINT [FK_Vidacha_Bibliotekar] FOREIGN KEY([id_bibliotekaria])
REFERENCES [dbo].[Bibliotekar] ([id_bibliotekaria])
GO
ALTER TABLE [dbo].[Vidacha] CHECK CONSTRAINT [FK_Vidacha_Bibliotekar]
GO
ALTER TABLE [dbo].[Vidacha]  WITH CHECK ADD  CONSTRAINT [FK_Vidacha_Chitatel] FOREIGN KEY([id_chitatelia])
REFERENCES [dbo].[Chitatel] ([id_chitatelia])
GO
ALTER TABLE [dbo].[Vidacha] CHECK CONSTRAINT [FK_Vidacha_Chitatel]
GO
ALTER TABLE [dbo].[Vidacha]  WITH CHECK ADD  CONSTRAINT [FK_Vidacha_Kniga] FOREIGN KEY([id_knigi])
REFERENCES [dbo].[Kniga] ([id_knigi])
GO
ALTER TABLE [dbo].[Vidacha] CHECK CONSTRAINT [FK_Vidacha_Kniga]
GO
ALTER TABLE [dbo].[Vozvrat]  WITH CHECK ADD  CONSTRAINT [FK_Vozvrat_Bibliotekar] FOREIGN KEY([id_bibliotekaria])
REFERENCES [dbo].[Bibliotekar] ([id_bibliotekaria])
GO
ALTER TABLE [dbo].[Vozvrat] CHECK CONSTRAINT [FK_Vozvrat_Bibliotekar]
GO
ALTER TABLE [dbo].[Vozvrat]  WITH CHECK ADD  CONSTRAINT [FK_Vozvrat_Chitatel] FOREIGN KEY([id_chitatelia])
REFERENCES [dbo].[Chitatel] ([id_chitatelia])
GO
ALTER TABLE [dbo].[Vozvrat] CHECK CONSTRAINT [FK_Vozvrat_Chitatel]
GO
ALTER TABLE [dbo].[Vozvrat]  WITH CHECK ADD  CONSTRAINT [FK_Vozvrat_Kniga] FOREIGN KEY([id_knigi])
REFERENCES [dbo].[Kniga] ([id_knigi])
GO
ALTER TABLE [dbo].[Vozvrat] CHECK CONSTRAINT [FK_Vozvrat_Kniga]
GO
