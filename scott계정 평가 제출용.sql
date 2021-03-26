create table namecard

(
    id             INT             not NULL PRIMARY key,
    name           VARCHAR2(10)     not NULL, 
    tel            VARCHAR2(20)     not NULL, 
    email          VARCHAR2(30)    NULL, 
    address          VARCHAR2(50)  not NULL
    
    );
--drop table namecard;
Create  sequence seq
start with 1
increment by 1
nomaxvalue
nominvalue;

insert into namecard values (seq.nextval,'홍길동','010-1111-2222','dkcms@naver.com','대구동구신암동');
insert into namecard values (seq.nextval,'김길동','010-1112-2222','dkcms1@naver.com','대구동구신암동');
insert into namecard values (seq.nextval,'박길동','010-1113-2222','dkcms12@naver.com','대구동구신암동');
select * from namecard where name like '%동';

select * from namecard order by id desc;

update namecard set name = '전우치' where name ='김길동';
SELECT  * FROM namecard order by name asc;

delete namecard where name = '전우치';

create table namecard_copy as select*from namecard;


