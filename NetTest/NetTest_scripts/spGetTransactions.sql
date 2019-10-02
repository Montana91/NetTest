Create PROCEDURE [dbo].[spGetTransactions] 
AS
select pca.pcaDT as DateTime, pca.pcaAmount as Amount, 'Category' as Category, 'who spent cash' as Person from tblPettyCashAudit pca
