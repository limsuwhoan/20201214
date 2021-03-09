package jdbc0226;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcTest {
	static Connection con;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" +DBNAME+ "?autoReconnect=true&serverTimezone=UTC";

	public static void main(String[] args) {
connectDB();
closeDB();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if(con !=null) {
				System.out.println("DB 立加 己傍!");
				
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
			System.out.println("DB 立加 辆丰!");
					}
		catch (SQLException e ) {
			e.printStackTrace();
		}
	
	}

}
