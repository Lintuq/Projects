USE [master]
GO

/****** Object:  BackupDevice [CollegeLibraryBackUp]    Script Date: 01.05.2022 18:16:01 ******/
EXEC master.dbo.sp_addumpdevice  @devtype = N'disk', @logicalname = N'CollegeLibraryBackUp', @physicalname = N'E:\SQL Server BackUPS\CollegeLibraryBackUp.bak'
GO


ALTER LOGIN IsabellaMakarova WITH PASSWORD = 'B3r1000d';
