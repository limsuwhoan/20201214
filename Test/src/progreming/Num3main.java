package progreming;


import java.util.ArrayList;

public class Num3main {

	private static int i;

	public static void main(String[] args) {
		ArrayList<Student>list= new ArrayList<Student>();
	String [] name = {"�̵���","������"};
	char [] gender = {'��','��'};
	int []num= {2009038033,2007012034};
	Student st[] = new Student[2];
	for (int i = 0; i < 2; i++) {
		st[i]=new Student(name[i], num[i], gender[i]);
	}

      st[i].setNum(2019038033);
      for (int i = 0; i < st.length; i++) {
	st[i].showStudentclassInfo();	
	}

	}
}
