using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{


    class Program
    {
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM = 3;
        const int MENU_EXIT = 4;
        const int MENU_CLEAR = 5;
        const int MENU_CHECK_CLEAR = 6;
        //static Student stud;
        static List<Student> addrList = new List<Student>();
        static void Main(string[] args)
        {
            //stud = Student.getInst();
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        Console.Write("[정보 추가]");
                        addItem();
                        break;
                    case MENU_VIEW:
                        Console.Write("[정보 보기]");
                        viewItem();
                        if (addrList.Count == 0) {
                        Console.WriteLine("정보가 없습니다"); }
                        break;
                    case MENU_RANDOM:
                        Console.Write("[랜덤으로 주소록 추가]");
                        randData();
                        break;
                    case MENU_EXIT:
                        Console.Write("[프로그램 종료]");
                        Environment.Exit(0);
                        break;
                    case MENU_CLEAR:
                        Console.Write("[저장된 정보 삭제]");

                        infoDel();
                        break;
                    case MENU_CHECK_CLEAR:
                        Console.WriteLine("지정된 사람의 정보만 삭제");
                        checkclear();
                        break;
                }
            }
        }

        public static void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("(이름):");
            string name = Console.ReadLine();
            Console.Write("(전화):");
            string tel = Console.ReadLine();
            Console.Write("(주소):");
            string address = Console.ReadLine();
            Console.Write("(이메일):");
            string email = Console.ReadLine();
            addrList.Add(new Student(name, tel, address, email));
        }
        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호:" + (i + 1) + "번");
                Console.WriteLine("이름:" + addrList[i].Name);
                Console.WriteLine("전화:" + addrList[i].Tel);
                Console.WriteLine("주소:" + addrList[i].Address);
                Console.WriteLine("이메일:" + addrList[i].Email);
                Console.WriteLine("------------------------");
            }
        }

        public static int getMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤으로 주소록 정보 추가");
            Console.WriteLine("4.프로그램 종료");
            Console.WriteLine("5.저장된 정보 전체삭제 ");
            Console.WriteLine("6.지정된 사람의 정보만 삭제하기");
            Console.WriteLine("-----------------");
            Console.WriteLine("메뉴 선택:");
            int menu =
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }

        public static void randData()
        {
            string[] name = { "홍길동", "홍차동", "홍갑동", "홍영동", "홍힝동" };
            string[] tel = { "01022113344", "01096113344", "01097113344", "01022111744", "01022343345" };
            string[] address = { "대구동구 신평동", "대구동구 방촌동", "대구동구동촌동", "대구동구신암동", "대구동구각산동" };
            string[] email = { "dkcmdcm@naver.com", "dkc12cm@naver.com", "cmdcm@naver.com", "demdcm@naver.com", "kdkkdcm@naver.com" };
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                addrList.Add(new Student(name[r.Next(0, 5)], tel[r.Next(0, 5)],
                    address[r.Next(0, 5)], email[r.Next(0, 5)]));
            }
        }
        public static void infoDel()
        {
            Console.WriteLine("저장된정보가 모두삭제 되었습니다.");
            addrList.Clear();
        }
        public static void checkclear()
        {
            Console.Write("삭제할 이름을 입력하세요: ");
            String name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name == addrList[i].Name)
                {
                    addrList.Remove(addrList[i]);
                    i--;
                }
            }
            Console.WriteLine(name + " 정보가 삭제 되었습니다.");
        }




    }
}


