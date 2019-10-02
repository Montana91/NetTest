Create Procedure spAuditInsert
@dt Datetime,
@username varchar(100),
@accType varchar(100),
@pcType varchar(100),
@debit decimal,
@sum decimal
As
INSERT INTO [dbo].[tblPettyCashAudit] ([pcaDT],[pcaAccount],[pcaAuditType],[pcaCategory],[pcaAmount],[pcaAmountCurrent]) VALUES(@dt,(select accId from tblAccount where accUserName=@username),(select actId from tblAccountType where actName=@accType),(select pccId from tblPettyCashCategory where pccKey=@pcType),@debit,@sum)
