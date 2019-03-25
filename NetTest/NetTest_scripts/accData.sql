declare @actkey char(10)

set @actkey = 'Emp'
if not exists (select * from tblAccountType where actKey=@actkey)
INSERT INTO [dbo].[tblAccountType]
           ([actId]
           ,[actName]
           ,[actKey])
     VALUES
           (NEWID(), 'Employee', @actkey)

set @actkey = 'Adm'

if not exists (select * from tblAccountType where actKey=@actkey)
INSERT INTO [dbo].[tblAccountType]
           ([actId]
           ,[actName]
           ,[actKey])
     VALUES
           (NEWID(), 'Admin', @actkey)

set @actkey = 'Dir'
if not exists (select * from tblAccountType where actKey=@actkey)
INSERT INTO [dbo].[tblAccountType]
           ([actId]
           ,[actName]
           ,[actKey])
     VALUES
           (NEWID(), 'Director', @actkey)

set @actkey = 'Man'
if not exists (select * from tblAccountType where actKey=@actkey)
INSERT INTO [dbo].[tblAccountType]
           ([actId]
           ,[actName]
           ,[actKey])
     VALUES
           (NEWID(), 'Manager', @actkey)




declare @uid uniqueidentifier
declare @accemp uniqueidentifier = (select actId from tblAccountType where actKey='Emp')
declare @accadm uniqueidentifier = (select actId from tblAccountType where actKey='Adm')
declare @accdir uniqueidentifier = (select actId from tblAccountType where actKey='Dir')
declare @accman uniqueidentifier = (select actId from tblAccountType where actKey='Man')

set @uid ='B781998C-485C-46C9-9059-895CF9077318'
if not exists (select * from tblAccount where accId=@uid)
INSERT INTO [dbo].[tblAccount]
           ([accId]
           ,[accFirstName]
           ,[accLastName]
		   ,[accUserName]
		   ,[accPwd]
		   )
     VALUES
           (@uid
           ,'John'
           ,'Kirkstone'
		   ,'jkirkstone'
		   ,'apple'
		   )
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accemp)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accemp)


set @uid ='BA2CFA9B-05C8-4458-A28C-5057E5CC4757'
if not exists (select * from tblAccount where accId=@uid)
INSERT INTO [dbo].[tblAccount]
           ([accId]
           ,[accFirstName]
           ,[accLastName]
		   ,[accUserName]
		   ,[accPwd]
		   )
     VALUES
           (@uid
           ,'Janet'
           ,'Sherwood'
		   ,'jsherwood'
		   ,'pear'
		   )
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accemp)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accemp)
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accdir)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accadm)


set @uid ='201102BA-B7D8-4F16-8DCC-8EA8C302FF14'
if not exists (select * from tblAccount where accId=@uid)
INSERT INTO [dbo].[tblAccount]
           ([accId]
           ,[accFirstName]
           ,[accLastName]
		   ,[accUserName]
		   ,[accPwd]
		   )
     VALUES
           (@uid
           ,'Graham'
           ,'Norcross'
		   ,'gnorcross'
		   ,'banana'
		   )
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accemp)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accemp)
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accdir)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accman)


set @uid ='8F17D7C5-2593-424B-84C1-82B0CF3BA3B8'
if not exists (select * from tblAccount where accId=@uid)
INSERT INTO [dbo].[tblAccount]
           ([accId]
           ,[accFirstName]
           ,[accLastName]
		   ,[accUserName]
		   ,[accPwd]
		   )
     VALUES
           (@uid
           ,'Jennifer'
           ,'Green'
		   ,'jgreen'
		   ,'orange'
		   )

if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accemp)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accemp)
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accadm)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accadm)


set @uid ='FA4BEB51-3BB2-402F-8298-96F5EFC9E133'
if not exists (select * from tblAccount where accId=@uid)

INSERT INTO [dbo].[tblAccount]
           ([accId]
           ,[accFirstName]
           ,[accLastName]
		   ,[accUserName]
		   ,[accPwd]
		   )
     VALUES
           (@uid
           ,'Karen'
           ,'Hide'
		   ,'khide'
		   ,'lemon'
		   )
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accemp)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accemp)
if not exists (select * from tblAccountTypeIndex where atiAccount=@uid and atiAccountType=@accdir)
	insert into tblAccountTypeIndex (atiAccount, atiAccountType) values (@uid, @accdir)

 set @uid = '1D5C9B9B-CB37-4BA3-AAE7-2BE18F0ECCBA'
 if not exists (select * from tblAuditType where autId=@uid)
 insert into tblAuditType (autId, autName, autKey) values (@uid, 'Login', 'Li')

 set @uid = 'ED914DC9-A49A-4BCB-9B9D-118A268B7AAD'
  if not exists (select * from tblAuditType where autId=@uid)
 insert into tblAuditType (autId, autName, autKey) values (@uid, 'Logout', 'Lo')

  set @uid = '1F5EF812-A3A3-41EB-BBBF-A223533CFDAC'
  if not exists (select * from tblAuditType where autId=@uid)
 insert into tblAuditType (autId, autName, autKey) values (@uid, 'Petty Cash Added', 'Ca')
  
  set @uid = '0E251344-EB3F-4F02-9E46-D1A2928937FC'
  if not exists (select * from tblAuditType where autId=@uid)
 insert into tblAuditType (autId, autName, autKey) values (@uid, 'Petty Cash Spent', 'Cs')

 set @uid = 'CEFC5B5B-E640-47A2-A3AD-B76A9E771742'
if not exists (select * from tblPettyCashCategory where pccId=@uid)
 INSERT INTO [dbo].[tblPettyCashCategory]
           ([pccId],[ppcName],[pccKey]) VALUES (@uid,'Tea/Coffee/Sugar/Milk','PC_Tea')

set @uid = '6721CE21-9615-4EAD-8751-A0920FE10C87'
if not exists (select * from tblPettyCashCategory where pccId=@uid)
 INSERT INTO [dbo].[tblPettyCashCategory]
           ([pccId],[ppcName],[pccKey]) VALUES (@uid,'Stationary','PC_Stat')

set @uid = 'A5A05566-D935-4040-BFDA-D3AAFDCA849D'
if not exists (select * from tblPettyCashCategory where pccId=@uid)
 INSERT INTO [dbo].[tblPettyCashCategory]
           ([pccId],[ppcName],[pccKey]) VALUES (@uid,'Travel Expenses','PC_Travel')

set @uid = '1AE2822A-1EC5-4E29-9670-56101BED344C'
if not exists (select * from tblPettyCashCategory where pccId=@uid)
 INSERT INTO [dbo].[tblPettyCashCategory]
           ([pccId],[ppcName],[pccKey]) VALUES (@uid,'Cleaning','PC_Clean')


set @uid = '00000000-0000-0000-0000-000000000000'
if not exists (select * from tblPettyCashCategory where pccId=@uid)
 INSERT INTO [dbo].[tblPettyCashCategory]
           ([pccId],[ppcName],[pccKey]) VALUES (@uid,'Nothing','PC_Nothing')
Go


--select NEWID()
select acc.accFirstName, acc.accLastName, acc.accUserName, at.actName from tblAccount acc inner join tblAccountTypeIndex ati on acc.accId=ati.atiAccount inner join tblAccountType at on ati.atiAccountType=at.actId
select * from tblPettyCashCategory


