USE [sitedb]
GO

Drop TABLE [dbo].[tblPettyCashAudit]
Go

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

declare @csum decimal
set @csum=1000.00
declare @cdebit decimal

set @cdebit = 121.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-09-24 14:36', @username='jkirkstone', @accType='Manager', @pcType='PC_Travel', @debit=@cdebit, @sum=@csum

set @cdebit = 65.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-09-25 14:36', @username='gnorcross', @accType='Employee', @pcType='PC_Tea', @debit=@cdebit, @sum=@csum

set @cdebit = 37.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-09-29 19:36', @username='jgreen', @accType='Admin', @pcType='PC_Stat', @debit=@cdebit, @sum=@csum

set @cdebit = 32.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-09-30 10:32', @username='khide', @accType='Admin', @pcType='PC_Clean', @debit=@cdebit, @sum=@csum

set @cdebit = 200.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-10-01 10:05', @username='jkirkstone', @accType='Manager', @pcType='PC_Travel', @debit=@cdebit, @sum=@csum

set @cdebit = -1000.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-10-02 11:23', @username='jsherwood', @accType='Director', @pcType='PC_Nothing', @debit=@cdebit, @sum=@csum

set @cdebit = 12.00
set @csum = @csum - @cdebit
exec spAuditInsert @dt='2019-09-11 12:45', @username='gnorcross', @accType='Employee', @pcType='PC_Tea', @debit=@cdebit, @sum=@csum
GO


