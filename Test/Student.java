package progreming;

public class Student {
private String name;
private int num;
private char gender;
public Student(String name, int num, char gender) {
	super();
	this.name = name;
	this.num = num;
	this.gender = gender;
}
public String getName() {
	return name;
}
public void setName(String name) {
	this.name = name;
}
public int getNum() {
	return num;
}
public void setNum(int num) {
	this.num = num;
}
public char getGender() {
	return gender;
}
public void setGender(char gender) {
	this.gender = gender;
}
public void showStudentclassInfo() {
	System.out.println("학번:"+num);
	System.out.println("이름:"+name);
	System.out.println("성별:"+gender);
}
}
