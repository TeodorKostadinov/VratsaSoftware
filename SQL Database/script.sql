USE [TestExport]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Agencies]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agencies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[PayRate] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Agencies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClBusinessCategs]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClBusinessCategs](
	[name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClCategories]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClCategories](
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClCourses]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClCourses](
	[universityId] [int] NULL,
	[categoryId] [int] NULL,
	[courseName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClCriterias]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClCriterias](
	[criteriaName] [nvarchar](50) NULL,
	[clCategoryId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClUniversities]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClUniversities](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[uniName] [nvarchar](max) NULL,
	[uniCity] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ClUniversities] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmCompanies]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmCompanies](
	[Name] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[clBusCatId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmCriterias]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmCriterias](
	[cmProjDetailsId] [int] NULL,
	[clCriteriasId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmProjects]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmProjects](
	[title] [nvarchar](50) NULL,
	[category] [nvarchar](50) NULL,
	[data] [nvarchar](50) NULL,
	[companyId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmProjectsDetails]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmProjectsDetails](
	[CmStudCoursesId] [int] NULL,
	[companyId] [int] NULL,
	[projectId] [int] NULL,
	[status] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmSolutions]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmSolutions](
	[CmProjDetailsId] [int] NULL,
	[data] [nvarchar](50) NULL,
	[companyGrade] [int] NULL,
	[teacherGrade] [int] NULL,
	[impact] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmStudentCourses]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmStudentCourses](
	[studentId] [int] NULL,
	[courseId] [int] NULL,
	[teachedId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmStudents]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmStudents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[courseYear] [tinyint] NOT NULL,
	[course] [nvarchar](max) NULL,
	[userID] [int] NOT NULL,
	[clUniversityId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.CmStudents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CmTeachers]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmTeachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[userID] [int] NOT NULL,
	[clUniversityId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.CmTeachers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CtgrsToBusCtgrs]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CtgrsToBusCtgrs](
	[clCategoryId] [int] NULL,
	[clBusinessCategoryId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FirstModels]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FirstModels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[BeautyIndex] [int] NOT NULL,
 CONSTRAINT [PK_dbo.FirstModels] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Messages]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[senderId] [int] NULL,
	[receiverId] [int] NULL,
	[date] [datetime] NULL,
	[isRead] [bit] NULL,
	[content] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/7/2014 10:11:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[CmStudents]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CmStudents_dbo.ClUniversities_clUniversityId] FOREIGN KEY([clUniversityId])
REFERENCES [dbo].[ClUniversities] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CmStudents] CHECK CONSTRAINT [FK_dbo.CmStudents_dbo.ClUniversities_clUniversityId]
GO
ALTER TABLE [dbo].[CmStudents]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CmStudents_dbo.Users_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CmStudents] CHECK CONSTRAINT [FK_dbo.CmStudents_dbo.Users_userID]
GO
ALTER TABLE [dbo].[CmTeachers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CmTeachers_dbo.ClUniversities_clUniversityId] FOREIGN KEY([clUniversityId])
REFERENCES [dbo].[ClUniversities] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CmTeachers] CHECK CONSTRAINT [FK_dbo.CmTeachers_dbo.ClUniversities_clUniversityId]
GO
ALTER TABLE [dbo].[CmTeachers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CmTeachers_dbo.Users_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CmTeachers] CHECK CONSTRAINT [FK_dbo.CmTeachers_dbo.Users_userID]
GO
