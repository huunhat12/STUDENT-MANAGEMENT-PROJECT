
CREATE PROC [dbo].[TAO_LOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USRNAME VARCHAR(50),
 @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  DECLARE @RETURN INT =0
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLSV_VB'
   IF (@RET =1)  -- LOGIN NAME BI TRUNG
   BEGIN
    SET @RETURN =1
     RETURN  @RETURN 
	END

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USRNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
	   SET @RETURN =2
       RETURN @RETURN
  END

IF (@ROLE ='ADMIN')
BEGIN
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addsrvrolemember @LGNAME, 'DBCreator'
  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  EXEC sp_addrolemember 'ADMIN', @USRNAME
END
ELSE  -- THUOC NHOM GIANGVIEN
BEGIN
   EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addrolemember 'GIANGVIEN', @USRNAME
END
RETURN 0  -- THANH CONG