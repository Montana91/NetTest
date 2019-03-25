if not exists (select * from sys.tables where name='tblAccount')
CREATE TABLE [dbo].[tblAccount](
	[accId] [uniqueidentifier] Not NULL,
	[accFirstName] [nvarchar](50) Not NULL,
	[accLastName] [nvarchar](50) Not NULL,
	[accUserName] [nvarchar](50) Not NULL,
	[accPwd] [nvarchar](50) Not NULL
) ON [PRIMARY]
GO

if not exists (select * from sys.tables where name='tblAccountType')
CREATE TABLE [dbo].[tblAccountType](
	[actId] [uniqueidentifier] NOT NULL,
	[actName] [nvarchar](50) NOT NULL,
	[actKey] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblAccountType] PRIMARY KEY CLUSTERED 
(
	[actId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

if not exists (select * from sys.tables where name='tblAccountTypeIndex')
CREATE TABLE [dbo].[tblAccountTypeIndex](
	[atiId] [int] identity (1,1) NOT NULL,
	[atiAccount] [uniqueidentifier] NOT NULL,
	[atiAccountType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tblAccountTypeIndex] PRIMARY KEY CLUSTERED 
(
	[atiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

if not exists (select * from sys.objects where name='tblAuditType')
CREATE TABLE [dbo].[tblAuditType](
	[autId] [uniqueidentifier] NOT NULL,
	[autName] [nvarchar](50) NOT NULL,
	[autKey] [varchar](10) NOT NULL
) ON [PRIMARY]
GO


if not exists (select * from sys.objects where name='tblAccountAudit')
CREATE TABLE [dbo].[tblAccountAudit](
	[acaId] [int] identity (1,1) NOT NULL,
	[acaDT] [datetime] NOT NULL,
	[acaAccount] [uniqueidentifier] NOT NULL,
	[acaAuditType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tblAccountAudit] PRIMARY KEY CLUSTERED 
(
	[acaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

if not exists (select * from sys.objects where name='tblPettyCashCategory')
CREATE TABLE [dbo].[tblPettyCashCategory](
	[pccId] [uniqueidentifier] NOT NULL,
	[ppcName] [nvarchar](50) NOT NULL,
	[pccKey] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblPettyCashCategory] PRIMARY KEY CLUSTERED 
(
	[pccId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

if not exists (select * from sys.tables where name='tblPettyCashAudit')
CREATE TABLE [dbo].[tblPettyCashAudit](
	[pcaId] [int] IDENTITY(1,1) NOT NULL,
	[pcaDT] [datetime] NOT NULL,
	[pcaAccount] [uniqueidentifier] NOT NULL,
	[pcaAuditType] [uniqueidentifier] NOT NULL,
	[pcaCategory] [uniqueidentifier] NOT NULL,
	[pcaAmount] [money] NOT NULL,
	[pcaAmountCurrent] [money] NOT NULL,
 CONSTRAINT [PK_tblPettyCashAudit] PRIMARY KEY CLUSTERED 
(
	[pcaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

