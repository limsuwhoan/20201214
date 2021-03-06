package com.lg.addrApp.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import com.lg.addrApp.model.AddrBook;
import com.lg.addrApp.util.Menu;

public class MySQLHandler {
   Connection con;
   Statement state;
   final String USER_ID = "root";
   final String USER_PW = "1126";
   final String DBNAME = "mydb";
   
   String jdbcDriver = 
         "com.mysql.cj.jdbc.Driver";
   String dbUrl = "jdbc:mysql://localhost/" +
      DBNAME + "?autoReconnect=true&" +
      "serverTimezone=UTC";
   
   public MySQLHandler() {
      connectDB();
   }
   
   private void connectDB() {
      try {
         Class.forName(jdbcDriver);
         con = DriverManager.getConnection(dbUrl,
            USER_ID, USER_PW);
         if (con != null) {
            state = con.createStatement();
            System.out.println("DB 접속 성공!");
         }
      } catch (ClassNotFoundException e) {
         e.printStackTrace();
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }
   
   public void closeDB() {
      try {
         state.close();
         con.close();         
         System.out.println("DB 접속 해제");
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }
   
   public void createTB() {
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
         checkError(e);
      }
   }
   
   public void dropTB() {
      String query = "drop table addrbook";
      try {
         state.executeUpdate(query);
      } catch (SQLException e) {
         checkError(e);
      }
   }
   
   public void checkError(SQLException e) {
      switch (e.getErrorCode()) {
      case 1050:
         System.out.println("테이블이 이미 존재합니다.");
         break;
      case 1051:
         System.out.println("삭제할 테이블이 존재하지 않습니다.");
         break;
      }
   }
   
   public void insertDB() {
      String query = "insert into addrbook values "
            + "(0, '홍길동', 100, 'hong@naver.com',"
            + "'010-1234-1234', '조선 한양 홍대감댁',"
            + "now())";
      
      String name = "전우치";
      int age = 200;
      String email = "jon@kakao.com";
      String tel = "010-111-1234";
      String addr = "조선 두메 산골";
      String query2 = String.format(
            "insert into addrbook(name,age,tel,address,email,date) "
            + "values" +"('%s,%d,'%s','%s','%s',now())", name,age,tel,addr,email);
      
      try {
         state.executeUpdate(query2);
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }
   public void updateDB(String [] str) {
      String query = String.format("update addrbook set name='%s'" + "where name='%s'",str[1],str[0]);
      
      
      
      try {
         state.executeUpdate(query);
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }
   public void deleteDB(String delName) {
      String query = String.format("delete from addrbook" + " where name='%s'",delName);
      
      
      
      try {
         state.executeUpdate(query);
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }
      public  void showDB() {
            String query = "select * from addrbook";
            try {
               ResultSet rs = state.executeQuery(query);
               if (rs != null) {
                  rs = state.getResultSet();
                  int n = 0;
                  while (rs.next()) {
                     System.out.print((n+1)+"\t");
                     ;
                     System.out.print(rs.getString(2) + "\t");
                     System.out.print(rs.getString(3) + "\t");
                     System.out.print(rs.getString(4) + "\t");
                     System.out.print(rs.getString(5) + "\t");
                     System.out.print(rs.getString(6) + "\t");
                     System.out.println(rs.getString(6));
                     n++;
                  }
                  rs.close();
               }
            } catch (SQLException e) {
               // TODO Auto-generated catch block
               e.printStackTrace();
            }
         } 
   
   public void insertDB(AddrBook ab) {      
      String query2 = String.format(
            "insert into addrbook (name, age,"
            + "tel, address, email, date)"
            + " values('%s',%d,'%s','%s','%s', now())", 
            ab.getName(), ab.getAge(), 
            ab.getTel(), ab.getAddress(),
            ab.getEmail());
      try {
         state.executeUpdate(query2);
      } catch (SQLException e) {
         e.printStackTrace();
      }
   }

}