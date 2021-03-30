using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
    class DaoOracle
    {
        const string CONNECT_ERR = "DB 접속";
        const string DISCONNECT_ERR = "접속 해제";
        const string CREATE_TB_ERR = "테이블 + 시퀀스 생성";
        const string DROP_TB_ERR = "테이블 + 시퀀스 삭제";
        const string ORADB = "Data Source = (DESCRIPTION=(ADDRESS_LIST="
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)"
            + "(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)"
            + "(SERVICE_NAME=XE)));"
            + "User Id=c##scott;Password=1126;";
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine(CONNECT_ERR + e);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                Console.WriteLine(DISCONNECT_ERR + e);
            }
        }


        public void createTable()
        {
            try
            {
                string query = "create table testTB (" + "id number not null," +
                    "name varchar(20) not null," +
                    "age number not null," +
                    "constraint pk_testTB_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id " + "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            Console.WriteLine(msg + "에러 번호" + e.Number);
            Console.WriteLine(msg + "에러 내용" + e.Message);
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "create table customer (" + "c_id INT NOT NULL," +
                    "c_name VARCHAR2(20) NOT NULL," +
                    " c_add VARCHAR2(40) NOT NULL," +
                    " c_tel VARCHAR2(30) NOT NULL," +
                    "c_email VARCHAR2(40) NULL," +
                    "CONSTRAINT CUSTOMER_PK PRIMARY KEY (c_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence customer_seq " + "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbCar()
        {
            try
            {
                string query = "create table Car (" + "v_id INT NOT NULL," +
                    "v_model VARCHAR2(20) NOT NULL," +                    
                    "v_price VARCHAR2(20) NOT NULL," +
                    "v_color VARCHAR2(20) NOT NULL," +
                    "v_year VARCHAR2(20) NULL," +
                    "v_manufacturer VARCHAR2(20) NOT NULL," +
                    " CONSTRAINT CAR_PK PRIMARY KEY (v_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence car_seq " + "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "create table Seller (" + "s_id  INT  NOT NULL," +
                    "s_name VARCHAR2(20) NOT NULL," +
                    "s_tel VARCHAR2(20) NOT NULL," +
                    "s_email VARCHAR2(20) NOT NULL," +
                    "s_spot VARCHAR2(20) NULL," +
                    "s_business VARCHAR2(20) NOT NULL," +
                    " CONSTRAINT SELLER_PK PRIMARY KEY (s_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seller_seq " + "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbDeal()
        {
            try
            {
                string query = "create table Deal (" + "d_id  INT  NOT NULL," +
                    "d_day VARCHAR2(20) NULL," +
                    "c_id INT NOT NULL," +
                    "v_id INT NOT NULL," +
                    "s_id INT NOT NULL," +
                    "  CONSTRAINT DEAL_PK PRIMARY KEY (d_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence deal_seq " + "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void createAllTB()
        {
            makeTbCar();
            makeTbCustomer();
            makeTbSeller();
            makeTbDeal();
        }

        public void dropAllTB()
        {
            dropTable("deal", "deal_seq");
            dropTable("customer", "customer_seq");
            dropTable("car", "car_seq");
            dropTable("seller", "seller_seq");
            

        }

        public void dropTable()
        {
            try
            {
                string query = "drop table testTB";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_testTB_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine(DROP_TB_ERR, e);
            }
        }
        public void dropTable(string tb, string seq)
        {
            try
            {
                string query = $"drop table {tb}";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = $"drop sequence {seq}";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine(DROP_TB_ERR, e);
            }
           
        }
        public void insertCar()
        {
            try
            {
                string sql = "insert into car values (car_SEQ.nextval," 
                    + "'그랜저',40000000, '은색','현대', '2021년')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch(OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }
        public void insertCar(Car car)
        {
            try
            {                
                string sql = string.Format("insert into car values(car_SEQ.nextval, "
                    + "'{0}',{1}, '{2}','{3}', '{4}')", car.Model, car.Price, car.Color, car.Year, car.Manufacturer);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }
        public void insertSeller()
        {
            try
            {
                string sql = "insert into seller values (seller_SEQ.nextval," + 
                    "'김철수', '010-1111-1234', 'kim@naver.com', '대리', '동대구영업소')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }
        public void insertSeller(Seller seller)
        {
            try
            {
                string sql = string.Format("insert into seller values(car_SEQ.nextval, "
                    + "'{0}',{1}, '{2}','{3}','{4}')", seller.Name, seller.Tel, seller.Email,seller.Spot,seller.Business);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }
        public void insertCustomer()
        {
            try
            {
                string sql = "insert into customer values (customer_SEQ.nextval," +
                    "'김순자', '010-1111-2222', '대구 동구 신천2동', 'kimsun@naver.com')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }
        public void insertCustomer(Customer customer)
        {
            try
            {
                string sql = string.Format("insert into customer values(car_SEQ.nextval, "
                    + "'{0}',{1}, '{2}','{3}')", customer.Name,customer.Tel,customer.Addr,customer.Email);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer(2)", e);
            }
        }
        public void insertDeal()
        {
            try
            {
                string sql = "insert into deal(d_id, d_day," +
                    " s_id, c_id, v_id)" +
                "(select deal_SEQ.nextval, sysdate," +
                "s.s_id, cu.c_id, ca.v_id" +
                " from seller s natural join customer cu " +
                "natural join car ca " +
                "where cu.c_name='김순자' and ca.v_model='그랜저' " +
                "and s.s_name='김철수')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

    }
}
    
