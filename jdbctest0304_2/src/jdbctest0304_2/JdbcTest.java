package jdbctest0304_2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import javax.swing.event.SwingPropertyChangeSupport;

public class JdbcTest {
   static final int CREATE_TABLE = 1;
   static final int DEL_TABLE = 2;
   static final int INSERT_DATA = 3;
   static final int RANDOM_DATA = 4;
   static final int VIEW_DATA = 5;
   static final int UPDATE_DATA = 6;
   static final int DEL_DATA = 7;
   static final int MAIN_EXIT = 8;

   static Connection con;
   static Statement state;
   static final String USER_ID = "root";
   static final String USER_PW = "1126";
   static final String DBNAME = "mydb";

   static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
   static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&" + "serverTimezone=UTC";

   public static void main(String[] args) {
      Scanner s = new Scanner(System.in);
      connectDB();
      while (true) {
         switch (menu(s)) {
         case CREATE_TABLE:
            createTB();
            break;
         case DEL_TABLE:
            dropTB();
            break;
         case INSERT_DATA:
            break;
         case VIEW_DATA:
            break;
         case RANDOM_DATA:
            break;
         case UPDATE_DATA:
            break;
         case DEL_DATA:
            break;
         case MAIN_EXIT:
            closeDB();
            s.close();
            System.exit(0);
            break;
            
         }
      }
   }

   public static int menu(Scanner s) {

      System.out.println("-----------------");
      System.out.println("MySQL DB ���� v1.0");
      System.out.println("-----------------");
      System.out.println("1. ���̺� ����");
      System.out.println("2. ���̺� ����");
      System.out.println("3. ������ �߰�");
      System.out.println("4. ���� ������ �߰�");
      System.out.println("5. ������ ����");
      System.out.println("6. ������ ����");
      System.out.println("7. ������ ����");
      System.out.println("8. ����");
      System.out.println("���� �޴� ����");

      return s.nextInt();

   }

   public static void connectDB() {
      try {
         Class.forName(jdbcDriver);
         con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
         if (con != null) {
            state = con.createStatement();
            System.out.println("DB ���� ����!");
         }
      } catch (ClassNotFoundException e) {
         e.printStackTrace();
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }

   public static void closeDB() {
      try {
         state.close();
         con.close();
         System.out.println("DB ���� ����");
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }
   
   public static void createTB() {
      String query = "create table addrbook (" 
          + "id INT(10) NOT NULL AUTO_INCREMENT,"
            + "name VARCHAR(10) NOT NULL," 
          + "age INT(3) NOT NULL," 
            + "tel VARCHAR(20) NOT NULL,"
            + "address VARCHAR(40) NOT NULL,"
            + "email VARCHAR(30) NULL,"
            + "date DATETIME NOT NULL,"
            + "PRIMARY KEY(id))";
      
      try {
      state.executeUpdate(query);
   } catch (SQLException e) {
//      System.out.println(e.getSQLState());
//      System.out.println(e.getMessage());
//      System.out.println(e.getErrorCode());
//      System.out.println(e.getCause().toString());
      
      if(e.getErrorCode()==1050) {
         System.out.println("���̺��� �̹� ���� �մϴ�.");
      }
   }
  }
   
   
   public static void dropTB() {
      String query = "drop table addrbook";
      try {
         state.executeUpdate(query);
      } catch (SQLException e) {                  
         if(e.getErrorCode()==1051) {
            System.out.println("������ ���̺��� �������� �ʽ��ϴ�.");
         }
   }
}
   
  
   public static void checkErrCode(SQLException e) {
	   switch(e.getErrorCode()) {
	   case 1050:
		   System.out.println("���̺��� �̹� �����մϴ�.");
	   break;
	   case 1051:
		   System.out.println("������ ���̺��� �������� �ʽ��ϴ�.");
		   break;
	   }
	  public static void
	   }
   }
}