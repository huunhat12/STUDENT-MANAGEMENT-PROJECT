ALTER PROCEDURE [dbo].[STT_BACKUP]
	AS
BEGIN
DECLARE @MEDIA_ID INT
SELECT @MEDIA_ID = MAX(media_set_id) FROM msdb.dbo.backupset
	WHERE database_name = 'QLSV_VB'
SELECT		position,backup_start_date FROM msdb.dbo.backupset
	WHERE	database_name = 'QLSV_VB' AND 
		backup_set_id > =
		(SELECT MAX (backup_set_id) FROM msdb.dbo.backupset
					WHERE media_set_id = @MEDIA_ID AND position=1)

END