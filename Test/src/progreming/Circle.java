package progreming;

public class Circle {
	static double rad = 0;
	final static double pi=3.14;
	
	public Circle(double rad) {
		this.rad=rad;
	}
	public double getRad(double rad) {
		return rad;
	}
	public void setRad(double rad) {
		this.rad=rad;
	}
	public static double getArea() {
		return pi*rad*rad;
	}

}
