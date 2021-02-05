
public class Mainserial {

	public static void main(String[] args) {

		new MYSerial().connect("COM4");
		System.out.println("포트사용가능");
	}

}
