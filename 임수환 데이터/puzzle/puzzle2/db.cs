using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle2
{
    class db
    {
        /*
         DataTable은 메모리 상의 하나의 테이블을 표현하는 개체이고 
         DataSet은 메모리 상의 DB를 표현하는 개체입니다. ... 
         DataSet 개체를 생성한 후에는 DB를 구성할 테이블과 관계를 정의할 수 있습니다.
             */
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt_rank = new DataTable();

        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                    "Initial Catalog = {1};" +
                    "Integrated Security = {2};" +
                    "Timeout = 3"
                    , "local", "mygame", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void selectQuery()
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM puzzle1" ;

            //DataAdapter와 DataSet으로 DB table 불러오기
            //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
            da = new SqlDataAdapter(cmd); //select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, "puzzle1");

            dt_rank = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.

            conn.Close(); //연결 해제

        }

        public static void insertQuery(int rank, int score, string name)
        {

            try
            {
                ConnectDB();
                string sqlcommand = "Insert Into puzzle1 (ranking, score, name) values (@parameter1, @p2, @p3)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                cmd.Parameters.AddWithValue("@parameter1", rank);
                cmd.Parameters.AddWithValue("@p2", score);
                cmd.Parameters.AddWithValue("@p3", name);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }   
        //출차인 경우에는 true 값을 넣어줌
        //선택적 변수(값을 넣을지 말지 선택)는 반드시 맨 마지막 파라메터에 위치해야 한다.
        public static void deleteQuery()
    {
        ConnectDB();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        string sqlcommand;
            sqlcommand = "Delete puzzle1";
        cmd.CommandText = sqlcommand;
        cmd.ExecuteNonQuery(); //쿼리 실행
        conn.Close();
    }
    }
   
}