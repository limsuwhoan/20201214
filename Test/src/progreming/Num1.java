package progreming;

import java.util.Scanner;

public class Num1 {

	public static void main(String[] args) {
Circle s=new Circle(3.14);
Scanner s1 = new Scanner(System.in);

System.out.println("������ �Է�");
Circle.rad=s1.nextInt();
if(Circle.rad<0) {
	System.out.println("��� �� �Է� �ٶ��ϴ�");
	System.exit(0);
}
System.out.println("������:"+Circle.rad);
System.out.println("����:"+Circle.getArea());
	}

}
