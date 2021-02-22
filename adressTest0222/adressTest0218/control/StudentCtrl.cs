using adressTest0218.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.control
{
    class StudentCtrl
    {
        List<Student> addrList =
            new List<Student>();
        RandData rand;

        public StudentCtrl()
        {
            rand = new RandData(new Random());
        }

        public void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
          
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            addrList.Add(
                new Student(rand.getId(), name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("ID: " + addrList[i].Id);
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }

        public void delItem(string name)
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }
        }

        public void delItemAll()
        {
            addrList.Clear();
        }

        public void randData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                addrList.Add(new Student(
                    rand.getId(),
                    rand.getName(),
                    rand.getTel(),
                    rand.getAddr(),
                    rand.getEmail()));
            }
        }

        public void updateItem(int menu)
        {
            /*수정메뉴 선택 하면  저장된 정보 에서 수정할 정보를 선택후 그에맞는 메뉴에 해당하는 (이름,전화번호,주소,이메일중 택)정보를
            수정 하고  수정되었다는 출력값 만들고 다시 저장 */
            for (int i = 0; i < addrList.Count; i++)
            {
                if (menu.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }

            }
            Console.Write("이름: ");

            string name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (menu.Equals(addrList[i].Tel))
                {
                    addrList.RemoveAt(i--);
                }
            }
            {
                Console.Write("전화: ");
                string tel = Console.ReadLine();
            }
            for (int i = 0; i < addrList.Count; i++)
            {
                if (menu.Equals(addrList[i].Address))
                {
                    addrList.RemoveAt(i--);
                }
            }
            {
                Console.Write("주소: ");
                string address = Console.ReadLine();
            }

            for (int i = 0; i < addrList.Count; i++)
            {
                if (menu.Equals(addrList[i].Email))
                {
                    addrList.RemoveAt(i--);
                }
            }
            {
                Console.Write("이메일: ");
                string email = Console.ReadLine();
            }
        }
    }
}


