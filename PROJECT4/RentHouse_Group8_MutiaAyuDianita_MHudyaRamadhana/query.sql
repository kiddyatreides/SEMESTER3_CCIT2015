create table customer (
id_customer varchar(4) PRIMARY KEY,
nama varchar(100),
birthdate date,
address text,
phonenumber varchar(20),
card_type varchar(100),
card_number varchar(100));

use renthouse;


drop table customer;

create table admin (
id_admin varchar(4) PRIMARY KEY,
nama varchar(100),
username varchar(100),
password varchar(50),
address text,
birthdate date,
phonenumber varchar(20),
admin_type varchar(100));

create table room(
id_room varchar(4) PRIMARY KEY,
id_room_type varchar(4),
name varchar(100),
price int,
status varchar(100));


drop table room;

select * from room_type;
insert into room (id_room,id_room_type,name,price,status) values ('C001','T001','001','500000','Available');
update room set id_room = 'R001' where name='001';
select A.id_room,A.name,A.id_room_type,A.status,B.id_room_type from room A,room_type B  where A.id_room_type = B.id_room_type AND A.status = 'Available';


ALTER TABLE room
ADD CONSTRAINT fk_RoomType
FOREIGN KEY (id_room_type)
REFERENCES room_type(id_room_type);

alter table room drop constraint fk_RoomType;


create table room_type(
id_room_type varchar(4) PRIMARY KEY,
name varchar(100));

select * from room_type;

create table transactionn(
id_transaction varchar(4) PRIMARY KEY,
id_room varchar(4),
id_customer varchar(4),
datein datetime,
dateout datetime,
status varchar(100));

select * from transactionn;
truncate table transactionn;
delete from transactionn where id_transaction='T001';
delete from transactionn where id_room='R002';

truncate table transactionn;
select A.id_transaction,A.id_room,A.id_customer,A.datein,A.dateout,A.status,B.name as namaroom,C.nama as namacustomer from transactionn A, room B, customer C where A.id_room = B.id_room AND A.id_customer = C.id_customer order by A.status,A.id_transaction ASC
update transactionn set status='Rent In' where id_transaction='T004';
update transactionn set dateout=null,status='Available' where id_transaction='T001';
update transactionn set status='Available' where id_transaction = 'T001'

select A.id_transaction,A.id_room,A.id_customer,A.datein,A.dateout,A.status from transactionn A, room B, customer C where A.id_room = B.id_room AND A.id_customer = C.id_customer order by A.id_transaction;

delete from transactionn where id_transaction='R003';

drop table transactionn;

ALTER TABLE transactionn drop constraint fk_Room;

ALTER TABLE transactionn
ADD CONSTRAINT fk_Room
FOREIGN KEY (id_room)
REFERENCES room(id_room);
alter table transactionn drop constraint fk_Customer;

ALTER TABLE transactionn
ADD CONSTRAINT fk_Customer
FOREIGN KEY (id_customer)
REFERENCES customer(id_customer);

create trigger tr_room_available on dbo.transactionn
after insert
as
declare @id_room varchar(4)
declare @id_room2 varchar(4)
begin
select @id_room = id_room from inserted
select @id_room2 = id_room from room
update room set status = 'Not Available' where  id_room = @id_room
end

create trigger tr_room_notavailable on dbo.transactionn
after update
as
declare @id_room varchar(4)
begin
select @id_room = id_room from inserted
update room set status = 'Available' where  id_room = @id_room
end

alter table transactionn
drop trigger tr_room_notavailable



create table monthlypaid(
id_monthlypaid varchar(4) PRIMARY KEY,
id_transaction varchar(4),
date_time datetime,
total int,
info text);

alter table monthlypaid drop constraint fk_Trans;
ALTER TABLE monthlypaid
ADD CONSTRAINT fk_Trans
FOREIGN KEY (id_transaction)
REFERENCES transactionn(id_transaction);

select * from monthlypaid;

truncate table monthlypaid;
select * from customer;

select A.id_monthlypaid,A.id_transaction,A.date_time,A.total,A.info,C.nama as namacustomer,D.name as namaroom from monthlypaid A,transactionn B,customer C,room D where A.id_transaction = B.id_transaction AND B.id_customer = C.id_customer AND B.id_room = D.id_room order by A.id_monthlypaid

update customer set id_customer = 'C001' where card_type='KTP';
delete from customer where card_type = 'KTP';
insert into customer values('P001','Kiddy','1998-01-01','Jakarta','124342','KTP','123123');
drop table monthlypaid;


ALTER TABLE Orders
ADD CONSTRAINT fk_PerOrders
FOREIGN KEY (P_Id)
REFERENCES Persons(P_Id)