
public class ManageStudent {

	public static void main(String[] args) {
		//���� 3-2
		Student s1= new Student("�尭��",1990380033,"��");
		Student s2= new Student("�����",2007010033,"��");
		//���� 3-3
		Student[] sArray= new Student[2];
		sArray[0]=s1;
		sArray[1]=s2;
		//���� 3-4
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			if(student.name.equals("�尭��"))
			{
				student.number = 2017038033;		
			}
		}
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			System.out.println(student);
		}
		
	}

}
