package progreming;

import java.util.Scanner;

public class Num1 {

	public static void main(String[] args) {
Circle s=new Circle(3.14);
Scanner s1 = new Scanner(System.in);

System.out.println("반지름 입력");
Circle.rad=s1.nextInt();
if(Circle.rad<0) {
	System.out.println("양수 만 입력 바랍니다");
	System.exit(0);
}
System.out.println("반지름:"+Circle.rad);
System.out.println("넓이:"+Circle.getArea());
	}

}
