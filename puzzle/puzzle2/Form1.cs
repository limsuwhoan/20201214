using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle2
{
    public partial class Form1 : Form
    {
        int Counter;
        public Form1()
        {
            InitializeComponent();
        }
        public void EmptySpotChecker(Button Butt1, Button Butt2)
        {
            if (Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }
        public void SolutionChecker()
        {//버튼 텍스트 값이 각 버튼 숫자와 같아지면 퍼즐 맞추기 성공
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" &&
                button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
                button7.Text == "7" && button8.Text == "8" && button9.Text == "9" &&
                button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                //퍼즐 완성시 텍스트 박스 에 이동횟수와  승리 메세지를 띄움
                MessageBox.Show("퍼즐 맞추기 성공! 당신이 승리!" + "이동횟수" + Counter + "회", "Shuffle Game", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Form3 form3 = new Form3(Counter);
                form3.ShowDialog();// 메시지 박스 가 나온후 폼 2 인 랭킹 시스템을 불러옴

                Form2 form2 = new Form2();
                form2.ShowDialog();// 폼2 에 저장한 텍스트 값과 함께 랭킹에 저장시킨 폼을 불러옴
            }
            Counter = Counter + 1;
            textBox1.Text = " 퍼즐 클릭횟수:" + Counter + "개";//텍스트 박스1에 입력될것
            textBox2.Text = Counter.ToString() + "개";//텍스트 박스2에 입력될것
        }
        public void Shuffle()
        {
            int[] bnum = new int[16];//배열에 퍼즐버튼 갯수 만큼 저장
            int i, j, rowchecker;// 변수 i ,j로 설정 rowchecker라는 변수도 선언
            bool flag = false;//변수에 조건을 줄떄 false 와 true 두가지의 조건만 줄 flag 변수 생성

            i = 1;
            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32((rnd.Next(0, 15)) + 1);// 0에서 15까지 랜덤 함수적용 , 버튼중 텍스트가없는 빈공간자리까지 풀러스해준다
                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowchecker)//반복횟수를 rowchecker함수에 저장
                    {
                        flag = true;//flag가  true 일때 실행
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;  
                }
                else
                {
                    bnum[i] = rowchecker;
                    i = i + 1;
                }
            }
            while (i <= 15); //버튼의 값을 초기값으로 바꿔서 원래 자리로 가면 게임에 승리하게됨
            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("게임을 종료 하시겠습니까?", "Shuffle Games",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Yes or NO 로 박스를 띄운다  

            if (iExit == DialogResult.No)
            {
                e.Cancel = true;//만약 no를 누르면 닫기 버튼을 취소
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            DialogResult iExit = MessageBox.Show("게임을 종료하시겠습니까?", "Shuffle Games",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Yes or NO 로 메세지 박스를 띄운다  

            if (iExit == DialogResult.Yes)// 만약 yes클릭시 
            {
                Application.ExitThread();//닫기 실행
            }
        }

        private void button18_Click(object sender, EventArgs e)//버튼 18 인 solution 클릭시 
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
            // 모든 퍼즐버튼의 값을 원래 위치 값으로 바꿔줌 (ex  "버튼1 에 1 의 값 이들어감 2 에는 2")
        }
        private void button1_Click(object sender, EventArgs e)
        // 버튼1 클릭시 1이 2 로 가거나 5 로 값이바껴서 이동가능
        {
            EmptySpotChecker(button1, button2);
            EmptySpotChecker(button1, button5);
            SolutionChecker();
        }
        // 버튼2 클릭시 텍스트값이 1,3,6 으로  값이바뀌게되어, 이동된 텍스트값이 바뀜 나머지도 동일
        private void button2_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button2, button1);
            EmptySpotChecker(button2, button3);
            EmptySpotChecker(button2, button6);
            SolutionChecker();
        }
        //버튼 3 값이 2,4,7 
        private void button3_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button3, button2);
            EmptySpotChecker(button3, button4);
            EmptySpotChecker(button3, button7);
            SolutionChecker();
        }
        //버튼 4 값이 3,8
        private void button4_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button4, button3);
            EmptySpotChecker(button4, button8);
            SolutionChecker();

        }
        //버튼 5 값이 1,6,9
        private void button5_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button5, button1);
            EmptySpotChecker(button5, button6);
            EmptySpotChecker(button5, button9);
            SolutionChecker();
        }
        //버튼 6 값이 2,5,7,10
        private void button6_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button6, button2);
            EmptySpotChecker(button6, button5);
            EmptySpotChecker(button6, button7);
            EmptySpotChecker(button6, button10);
            SolutionChecker();
        }
        //버튼 7 값이 3,6,11,8
        private void button7_Click(object sender, EventArgs e)
        {

            EmptySpotChecker(button7, button3);
            EmptySpotChecker(button7, button6);
            EmptySpotChecker(button7, button11);
            EmptySpotChecker(button7, button8);
            SolutionChecker();
        }
        //버튼 8 값이 4,7,12
        private void button8_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button8, button4);
            EmptySpotChecker(button8, button7);

            EmptySpotChecker(button8, button12);
            SolutionChecker();
        }
        //버튼 9값이 5,10,13
        private void button9_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button9, button5);
            EmptySpotChecker(button9, button10);

            EmptySpotChecker(button9, button13);
            SolutionChecker();
        }
        //버튼 10 값이 6,9,11,14
        private void button10_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button10, button6);
            EmptySpotChecker(button10, button9);
            EmptySpotChecker(button10, button11);
            EmptySpotChecker(button10, button14);
            SolutionChecker();
        }
        //버튼 11 값이 7,10,12,15
        private void button11_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button11, button7);
            EmptySpotChecker(button11, button10);
            EmptySpotChecker(button11, button15);
            EmptySpotChecker(button11, button12);
            SolutionChecker();
        }
        //버튼 12 값이 8,11,16
        private void button12_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button12, button8);
            EmptySpotChecker(button12, button11);
            EmptySpotChecker(button12, button16);
            SolutionChecker();
        }
        //버튼 13 값이 9,14
        private void button13_Click(object sender, EventArgs e)
        {

            EmptySpotChecker(button13, button9);
            EmptySpotChecker(button13, button14);
            SolutionChecker();
        }
        //버튼 14 값이 10,13,15
        private void button14_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button14, button13);
            EmptySpotChecker(button14, button10);
            EmptySpotChecker(button14, button15);
            SolutionChecker();
        }
        //버튼 15 값이 11,14,16
        private void button15_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button15, button14);
            EmptySpotChecker(button15, button11);
            EmptySpotChecker(button15, button16);
            SolutionChecker();
        }
        //버튼 16 값이 12,15
        private void button16_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button16, button12);
            EmptySpotChecker(button16, button15);
            SolutionChecker();
        }
        //  버튼(버튼 17)Reset 클릭시 퍼즐의 버튼값이 렌덤으로 바뀌고 텍스트에있는 값들을 없애버림
        private void button17_Click(object sender, EventArgs e)
        {
            Shuffle();
            textBox1.Clear();
            textBox2.Clear();
            Counter = 0;
        }
        //버튼 New Game 클릭시 퍼즐의 버튼값이 렌덤으로바뀌고 텍스트박스의 값을 초기화시키고 게임을 다시새로 시작함
        private void button19_Click(object sender, EventArgs e)
        {
            Shuffle();
            textBox1.Clear();
            textBox2.Clear();
            this.Refresh();
            this.Hide();
            Form1 newgame = new Form1();
            newgame.Show();
}
     
        private void button21_Click(object sender, EventArgs e)//부가설명 (게임설명)추가
        {
            MessageBox.Show("[●게임 설명●] : 왼쪽의 숫자퍼즐을 옮겨 1~15까지의 숫자를 차례대로 " +
                "만드는  숫자퍼즐 맞추기 게임 입니다.   " +
                "\n" +
                "\n" +
                "\n" + "ex)" +
                "\n" + "(※Reset)  클릭시 퍼즐이 섞입니다." +
                "\n" + "(※solution)  클릭시 퍼즐이 모두 맞춰진 상태로 바뀝니다.." +
                "\n" + "(※New Game)  클릭시 새로운 게임을 시작 합니다." +
                "\n" + "(※quit)  클릭시 게임이 종료 됩니다. "
                );
        }
    }
}
