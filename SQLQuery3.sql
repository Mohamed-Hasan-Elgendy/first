create database users
on primary
(name ='users',filename='D:\LIBRARY\users.mdf')
log on
(name ='users_log',filename='D:\LIBRARY\users_log.ldf')
use users 
create table accounts
(
account_id int primary key,
account_name nvarchar (50),
account_password nvarchar (50)
)
insert into accounts
(account_id,account_name,account_password)
values 
(1,'mohamed','123'),
(2,'mhm','1357'),
(3,'omar','2468'),
(4,'admin','admin@30'),
(5,'mohamed','123456')
select* from accounts