
public class Student {
 String name;
 int number ; 
 String gender;
 
 public Student(String n, int num ,String g)
 {
	 name= n;
	 number = num;
	 gender = g ;
 }
 @Override
	public String toString() {
		// TODO Auto-generated method stub
//		return super.toString();
	 return "내이름은 "+ name +","+"내 학번은"+number+","+"나는"+gender+"자야";
 }
}
