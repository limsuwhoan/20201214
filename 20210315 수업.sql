select sum(salary) as "급여총액",
    avg(salary) as "급여평균",
    max(salary) as "최대급여",
    min(salary) as "최소급여" from employee;
    
select count(DISTINCT job) as "직업 종류 개수" from employee;
select dno as "부서 번호", avg(salary) as "급여 평균" from employee group by dno;


select dno, job, count(*), sum(salary) from employee group by dno, job order by dno, job;
select dno, max(salary) from employee group by dno having max(salary) >= 1000;
select * from employee, department where employee.eno = department.dno;
select e.eno, e.ename, d.dname, e.dno 
from employee e, department d 
where e.dno = d.dno and e.eno = 7777;

select e.eno, e.ename, d.dname, dno 
from employee e join department d using(dno)
where e.eno = 7777;

select e.eno, e.ename, d.dname, e.dno
from employee e join department d
on e.dno = d.dno where e.eno = 7777;

select e.ename, d.dname, e.salary, s.grade
from employee e, department d, salgrade s
where e.dno = d.dno and e.salary between s.losal and s.hisal;

select ename,dno from employee
WHERE dno = (select dno from employee WHERE ename ='SCOTT');