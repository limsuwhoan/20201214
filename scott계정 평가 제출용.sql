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

insert into namecard values (seq.nextval,'ȫ�浿','010-1111-2222','dkcms@naver.com','�뱸�����žϵ�');
insert into namecard values (seq.nextval,'��浿','010-1112-2222','dkcms1@naver.com','�뱸�����žϵ�');
insert into namecard values (seq.nextval,'�ڱ浿','010-1113-2222','dkcms12@naver.com','�뱸�����žϵ�');
select * from namecard where name like '%��';

select * from namecard order by id desc;

update namecard set name = '����ġ' where name ='��浿';
SELECT  * FROM namecard order by name asc;

delete namecard where name = '����ġ';

create table namecard_copy as select*from namecard;


