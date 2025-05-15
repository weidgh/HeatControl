use master
go
if exists(select * from sysdatabases where name='HeatingControlDB')
drop database HeatingControlDB
go
create database  HeatingControlDB
on primary
(
    name='HeatingControlDB_data',
	filename='D:\DB\HeatingControlDB_data.mdf',
	size=100MB,
	filegrowth=50MB
)
log on
(
   name='HeatingControlDB_log',
	filename='D:\DB\HeatingControlDB_log.ldf',
	size=100MB,
	filegrowth=50MB
)
go

use HeatingControlDB
go

--创建《用户表》
if exists(select * from sysobjects where name='SysAdmin')
drop table SysAdmin
go
create table SysAdmin
(
      LoginId int identity(10000,1) primary key, --用户Id
      LoginName varchar(100) not null,
      LoginPwd varchar(20) not null,
      RoleName varchar(20) not null
)
go

insert into SysAdmin(LoginName,LoginPwd,RoleName) values('Admin','111111','管理员')

Select * from  SysAdmin

if exists(select * from sysobjects where name='ActualData')
drop table ActualData
go
create table ActualData 
(
    Id int identity(1,1) primary key, 
    InsertTime dateTime not null,
    PressureIn varchar(10) not null,
    PressureOut varchar(10)  not null,
    TempIn varchar(10)  not null,
    TempOut varchar(10)  not null,
	PressureBoiler varchar(10)  not null,
    LevelBoiler varchar(10)  not null,
	TempBoiler varchar(10)  not null,
    LevelTank varchar(10)  not null
)

select *  from ActualData

Select LoginId,LoginName,LoginPwd,RoleName from SysAdmin

select * from   ActualData

