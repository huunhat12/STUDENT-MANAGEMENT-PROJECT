ALTER PROC[dbo].[KT_LOGIN_USERNAME]
@MAGV NCHAR(10)
AS
BEGIN
SELECT name FROM sys .server_principals 
WHERE sid = (SELECT sid FROM sys .sysusers WHERE name=@MAGV )
END
--KT_LOGIN_USERNAME 'PTITCN01'