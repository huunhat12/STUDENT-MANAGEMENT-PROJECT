CREATE PROC [dbo].[KT_MAGV]
@MAGV NCHAR(10)
AS
BEGIN
SET NOCOUNT ON;
	IF EXISTS (SELECT MAGV FROM GIANGVIEN  WHERE MAGV=@MAGV )
		RETURN 1
	ELSE
		RETURN 0
END