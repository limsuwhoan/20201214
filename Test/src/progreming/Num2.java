package progreming;

import java.util.Scanner;

public class Num2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("당신의 띠를 구해드리겠습니다.");
		System.out.println("출생 연도를 입력하시오.");
		int a = s.nextInt();
		switch (a % 12) {
		case 0:
			System.out.println("원숭이 띠입니다.");
			break;

		case 1:
			System.out.println("닭 띠입니다.");
			break;

		case 2:
			System.out.println("개 띠입니다.");
			break;
		case 3:
			System.out.println("돼지 띠입니다.");
			break;

		case 4:
			System.out.println("쥐 띠입니다.");
			break;

		case 5:
			System.out.println("소 띠입니다.");
			break;

		case 6:
			System.out.println("호랑이 띠입니다.");
			break;

		case 7:
			System.out.println("토끼 띠입니다.");
			break;

		case 8:
			System.out.println("용 띠입니다.");
			break;

		case 9:
			System.out.println("뱀 띠입니다.");
			break;

		case 10:
			System.out.println("말 띠입니다.");
			break;

		case 11:
			System.out.println("양 띠입니다.");
			break;

		}
	}
}