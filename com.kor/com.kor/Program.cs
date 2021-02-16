using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.kor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '여', '남'};
            string[] adr = {"대구시 동구 신암동","대구시 남구 남구동","대구시 동구 방촌동","대구시 동구 동촌동","대구시 동구 신천동"
        };//정보 배열 초기화 시킴

            Student[] sw = new Student[10];//열명의 학생의 정보를 저장할수 있는  배열 만듬
            Random r = new Random();//랜덤 선언
            for (int a = 0; a < sw.Length; a++)//반복
            {
                sw[a] = new Student(name[r.Next(0, 5)], age[r.Next(0, 5)], gender[r.Next(0, 2)]
                    , adr[r.Next(0, 5)]);
                sw[a].showStudentinfo();//
            }

            // 1. 객체 생성
            // 2. 정보를 인스턴스 변수로 전달
            Student st = new Student(name[r.Next(0, 5)], age[r.Next(0, 5)], gender[r.Next(0, 5)]
                    , adr[r.Next(0, 5)]);
            st.showStudentinfo();

        }

    }

}
