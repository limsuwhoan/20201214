package progreming;

import java.util.Scanner;

public class Num2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("����� �츦 ���ص帮�ڽ��ϴ�.");
		System.out.println("��� ������ �Է��Ͻÿ�.");
		int a = s.nextInt();
		switch (a % 12) {
		case 0:
			System.out.println("������ ���Դϴ�.");
			break;

		case 1:
			System.out.println("�� ���Դϴ�.");
			break;

		case 2:
			System.out.println("�� ���Դϴ�.");
			break;
		case 3:
			System.out.println("���� ���Դϴ�.");
			break;

		case 4:
			System.out.println("�� ���Դϴ�.");
			break;

		case 5:
			System.out.println("�� ���Դϴ�.");
			break;

		case 6:
			System.out.println("ȣ���� ���Դϴ�.");
			break;

		case 7:
			System.out.println("�䳢 ���Դϴ�.");
			break;

		case 8:
			System.out.println("�� ���Դϴ�.");
			break;

		case 9:
			System.out.println("�� ���Դϴ�.");
			break;

		case 10:
			System.out.println("�� ���Դϴ�.");
			break;

		case 11:
			System.out.println("�� ���Դϴ�.");
			break;

		}
	}
}