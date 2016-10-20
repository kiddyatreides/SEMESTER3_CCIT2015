SELECT A.id_rent,B.id_customer,B.id_room,C.price from tb_monthly_paid A, tb_rent B, tb_room C WHERE A.id_rent = B.id_rent AND B.id_room = C.id_room

SELECT A.id_monthly_paid,A.id_rent,D.name,B.id_room,C.price from tb_monthly_paid A, tb_rent B, tb_room C,tb_customer D WHERE A.id_rent = B.id_rent AND B.id_room = C.id_room AND B.id_customer = D.id_customer;

SELECT A.id_rent,A.date_time,B.name,A.id_room,C.price from tb_rent A, tb_customer B, tb_room C where B.name like 'ojan' AND A.id_room = C.id_room AND A.id_customer = B.id_customer AND A.date_out IS NULL;