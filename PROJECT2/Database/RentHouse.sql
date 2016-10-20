use rent_house

create table tb_customer(
id_customer varchar(4) PRIMARY KEY,
name varchar(100),
card_type varchar(10),
id_no varchar(25),
gender varchar(10),
birthdate date,
phone varchar(13),
address text);


drop table tb_customer

alter table tb_customer ADD FOREIGN KEY (id_type) REFERENCES tb_card_type(id_type);



drop table tb_card_type;



create table tb_room(
id_room varchar(4) PRIMARY KEY,
name varchar(50),
price integer,
id_type_room varchar(4),
status varchar(20));

alter table tb_room ADD FOREIGN KEY (id_type_room) REFERENCES tb_type_room(id_type_room);

--Membuat ROOM Not available saat dimasukan data
create trigger tr_otomatis_available on dbo.tb_room
after insert
as
declare @id_room varchar (4)
declare @status varchar (4)
begin
select @id_room = id_room from inserted
update tb_room set status = 'Available' Where id_room = @id_room;
end



create table tb_type_room(
id_type_room varchar(4) PRIMARY KEY,
name varchar(50),
description text);

create table tb_rent(
id_rent varchar(4) PRIMARY KEY,
id_customer varchar(4),
id_room varchar(4),
date_time datetime,
date_out datetime
);


select * from tb_room;

drop trigger tr_status
--Membuat ROOM Not available saat dimasukan data
create trigger tr_status on dbo.tb_rent
after insert
as
declare @id_room varchar (4)
declare @status varchar (4)
begin
select @id_room = id_room from inserted
select @status = status from tb_room
update tb_room set status = 'Not Available' Where id_room = @id_room;
end

drop trigger tr_status_out
--Membuat Trigger Room menjadi available saat diupdate
create trigger tr_status_out on dbo.tb_rent
after update
as
declare @id_room varchar (4)
declare @date date
declare @status varchar (4)
begin
select @id_room = id_room from inserted
select @date = date_out from inserted
select @status = status from tb_room
update tb_room set status = 'Available' Where id_room = @id_room;
end



alter table tb_rent ADD CONSTRAINT fk_customer FOREIGN KEY (id_customer) REFERENCES tb_customer(id_customer);
alter table tb_rent ADD FOREIGN KEY (id_room) REFERENCES tb_room(id_room);


create table tb_monthly_paid(
id_monthly_paid int IDENTITY(1,1) PRIMARY KEY,
id_rent varchar(4),
date_time datetime,
total integer);

alter table tb_monthly_paid ADD CONSTRAINT PK_MONTHLY_PAID PRIMARY KEY(id_rent,date_time);

drop table tb_monthly_paid
use rent_house
create table tb_admin(
id_admin varchar(4) PRIMARY KEY,
username varchar(50),
password varchar(50),
name varchar(50),	
gender varchar(10),
roles varchar(50));

alter table tb_monthly_paid ADD FOREIGN KEY (id_rent) REFERENCES tb_rent(id_rent);

create table tb_laundry(
id_transaction varchar(4) PRIMARY KEY,
id_customer varchar(4),
date_time date,
date_take date,
real_date_take date,
id_type_laundry varchar(4),
id_laundry_genre varchar(10));



create table tb_laundry(
id_transaction varchar(4) PRIMARY KEY,
id_customer varchar(4),
date_time date,
date_take date,
real_date_take date,
id_type_laundry varchar(4),
id_laundry_genre varchar(4)
);

drop table tb_laundry;

--Ambil jenis
create trigger tr_jadwal_ambil on dbo.tb_laundry
after insert
as
declare @id_trans varchar (4)
declare @date date
declare @date_take date
declare @type varchar (4)
begin
select @id_trans = id_transaction from inserted
select @type = id_laundry_genre from inserted
select @date = date_time from inserted
select @date_take = date_take from inserted
if(@type = 'G001')
update tb_laundry set date_take = DATEADD(DAY,1, date_time) Where id_transaction = @id_trans
if(@type = 'G002')
update tb_laundry set date_take = DATEADD(DAY,3, date_time) Where id_transaction = @id_trans  
if(@type = 'G003')
update tb_laundry set date_take = DATEADD(DAY,5, date_time ) Where id_transaction = @id_trans
end
truncate table tb_laundry;

drop trigger tr_jadwal_ambil;

select * from tb_laundry;

SELECT id_transaction,DATEADD(day,3,date_time) AS OrderPayDate
FROM tb_laundry where id_transaction = 'L001'

alter table tb_laundry ADD FOREIGN KEY (id_type_laundry) REFERENCES tb_type_laundry(id_type_laundry);
alter table tb_laundry ADD CONSTRAINT fk_laundry2 FOREIGN KEY (id_laundry_genre) REFERENCES tb_laundry_genre(id_laundry_genre);

ALTER TABLE tb_laundry DROP CONSTRAINT fk_laundry2
 

create table tb_laundry_genre(
id_laundry_genre varchar(4) PRIMARY KEY,
name varchar(50),
description text);

drop table tb_laundry_genre;

create table tb_type_laundry(
id_type_laundry varchar(4) PRIMARY KEY,
name varchar(50),
description text);



