package jdbc0226;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.mysql.cj.xdevapi.Statement;

public class JdbcTest {
	static Connection con;
	static java.sql.Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	private static String conut;

	public static void main(String[] args) {
		connectDB();
		insertDB();
		showDB();
		closeDB();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공!");

			}
		} catch (InstantiationException e) {

			e.printStackTrace();
		} catch (IllegalAccessException e) {

			e.printStackTrace();
		} catch (ClassNotFoundException e) {

			e.printStackTrace();
		} catch (SQLException e) {

			e.printStackTrace();
		}
	}

	public static void closeDB() {
		try {
			con.close();
			state.close();
			System.out.println("DB 접속 종료!");
		} catch (SQLException e) {
			e.printStackTrace();
		}

	}

	public static void insertDB() {
		String query = "insert into db values (0,'홍길동','010-1111-1111','남','11112979','동대구역')";
		String name = "전우치";

		String job = "혁명가";
		String hobby = "팔도유람";

		String query2 = String.format("insert into userinfo (name, job, hobby) values ('%s','%s','%s')", name, job,
				hobby);

		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void showDB() {
			String query = "select * from userinfo";			
			ResultSet rs;
			try {
				rs = state.executeQuery(query);
				if (rs!=null) {
					rs = state.getResultSet();
					int cnt =0;					
					while ( rs.next()) {
						System.out.print((cnt+1) +"\t");
						System.out.print(rs.getString("name")+"\t");
						System.out.print(rs.getString("job")+"\t");
						System.out.println(rs.getString(4));			
						cnt++;
					}
					rs.close();
				}
			} catch (SQLException e) {
				e.printStackTrace();
			}			
	}
}
