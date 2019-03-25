declare @accuser nvarchar(50)
declare @dt datetime

declare @accid uniqueidentifier
declare @audid uniqueidentifier


set @accuser = 'jjgreen'
set @dt = '2019-03-24 17:11:00'


set @audid = (select autId from tblAuditType where autKey='Li')

set @accid = (select accId from tblAccount where accUserName=@accuser)

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
select @accid
GO
