if exists (select * from sys.procedures where name = 'spGetAccountLoggedIn')
Drop PROCEDURE spGetAccountLoggedIn
Go
 
CREATE PROCEDURE spGetAccountLoggedIn 
AS

select top (1) aa.acaAccount from tblAccountAudit aa inner join tblAuditType at on aa.acaAuditType=at.autId
where at.autKey='Li'
 order by aa.acaDT desc

GO

if exists (select * from sys.procedures where name = 'spAccountLogin')
Drop PROCEDURE spAccountLogin
Go

CREATE PROCEDURE spAccountLogin
	@accusername nvarchar(50),
	@accpwd nvarchar(50),
	@dt datetime
AS
declare @accid uniqueidentifier
declare @audid uniqueidentifier

set @audid = (select autId from tblAuditType where autKey='Li')

set @accid = (select accId from tblAccount where accUserName=@accusername and accPwd=@accpwd)

if not @accid is null
INSERT INTO [dbo].[tblAccountAudit]
           ([acaDT]
           ,[acaAccount]
           ,[acaAuditType])
     VALUES
           (@dt
           ,@accid
           ,@audid
		   )
select @accid as acaAccount
GO

if exists (select * from sys.procedures where name = 'spCashUpdate')
Drop PROCEDURE [dbo].[spCashUpdate]
Go

Create PROCEDURE [dbo].[spCashUpdate] 
	@dt datetime,
	@accid uniqueidentifier,
	@catid uniqueidentifier,
	@cash money,
	@addspend varchar(10)
AS
declare @audid uniqueidentifier
declare @cashtotal money

set @audid = (select top (1) autId from tblAuditType where autKey=@addspend)
set @cashtotal = isnull((select top (1) pcaAmountCurrent from tblPettyCashAudit order by pcaDT desc), 0.0)
if @addspend = 'Ca'
set @cashtotal = @cashtotal + @cash
if @addspend = 'Cs'
set @cashtotal = @cashtotal - @cash

if @addspend='Ca' or @addspend='Cs'
INSERT INTO [dbo].[tblPettyCashAudit]
           ([pcaDT]
           ,[pcaAccount]
           ,[pcaAuditType]
           ,[pcaCategory]
           ,[pcaAmount]
           ,[pcaAmountCurrent])
     VALUES
           (@dt
           ,@accid
           ,@audid
		   ,@catid
		  ,@cash
		  ,@cashtotal)

select @cashtotal as cashtotal

Go

if exists (select * from sys.procedures where name = 'spCashReadList')
Drop PROCEDURE [dbo].[spCashReadList]
Go
CREATE PROCEDURE spCashReadList

AS
 select * from tblPettyCashAudit pca inner join tblAccount acc on acc.accId=pca.pcaAccount inner join tblAuditType at on pca.pcaAuditType=at.autId order by pcaDT desc

GO

if exists (select * from sys.procedures where name = 'spAccountReadById')
Drop PROCEDURE [dbo].[spAccountReadById]
Go
CREATE PROCEDURE spAccountReadById 
	@accId uniqueidentifier
AS
	select acc.accId, acc.accFirstName, acc.accLastName, acc.accUserName, act.actKey, act.actName from tblAccount acc
	 inner join tblAccountTypeIndex ati on acc.accId=ati.atiAccount
	 inner join tblAccountType act on act.actId=ati.atiAccountType
	where acc.accId = @accId
GO

if exists (select * from sys.procedures where name = 'spCashSpendCategory')
Drop PROCEDURE [dbo].[spCashSpendCategory]
Go
CREATE PROCEDURE spCashSpendCategory 
AS
select * from tblPettyCashCategory where pccKey != 'PC_Nothing' order by ppcName asc
GO

