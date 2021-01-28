using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace 계산기

{

    public partial class Form1 : Form

    {

        string operand; // 피연산자1 저장

        string operand2; // 피연산자2 저장



        bool operand_check = false; // 피연산자1과 피연산자2중 무엇을 사용할지 확인

        // 연산자 즉, 더하기 ~ 나머지 버튼을 누르기 전에는 operand에 저장 누른 후에는 operand2에 값 저장

        // 이해완료햇쥬?

        // 첫 값은 무조건 operand에 저장해야 하므로 false로 설정 (개발자 마음대로~)



        double result; // 결과값



        int my_operator; // 무슨 연산자인지 확인하는 int형 flag

        // 더하기 = 1 , 빼기 = 2 , 곱하기 = 3 , 나누기 = 4 , 나머지 = 5

        // Constants로 상수 정의

        public const int ADD = 1;

        public const int SUB = 2;

        public const int MUL = 3;

        public const int DIV = 4;

        public const int REMAIN = 5;



        public Form1()

        {

            InitializeComponent();

            label1.Text = "여기에는 수 저장";

            label2.Text = "여기에는 현재 수 저장";

        }



        private void Btn_1_Click(object sender, EventArgs e)

        {

            if (operand_check == false)   // 연산자 누른 후 인지 아닌지 확인 후 operand에 값저장

            {

                operand += "1";          // 연산자를 누르기 전, operand에 값저장

                label2.Text = operand;

            }

            else

            {

                operand2 += "1";        // 연사자를 누른 후, operand2에 값저장

                label2.Text = operand2;

            }

        }



        private void Btn_2_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "2";

                label2.Text = operand;

            }

            else

            {

                operand2 += "2";

                label2.Text = operand2;

            }

        }



        private void Btn_3_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "3";

                label2.Text = operand;

            }

            else

            {

                operand2 += "3";

                label2.Text = operand2;

            }

        }



        private void Btn_4_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "4";

                label2.Text = operand;

            }

            else

            {

                operand2 += "4";

                label2.Text = operand2;

            }

        }



        private void Btn_5_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "5";

                label2.Text = operand;

            }

            else

            {

                operand2 += "5";

                label2.Text = operand2;

            }

        }



        private void Btn_6_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "6";

                label2.Text = operand;

            }

            else

            {

                operand2 += "6";

                label2.Text = operand2;

            }

        }



        private void Btn_7_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "7";

                label2.Text = operand;

            }

            else

            {

                operand2 += "7";

                label2.Text = operand2;

            }

        }



        private void Btn_8_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "8";

                label2.Text = operand;

            }

            else

            {

                operand2 += "8";

                label2.Text = operand2;

            }

        }



        private void Btn_9_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "9";

                label2.Text = operand;

            }

            else

            {

                operand2 += "9";

                label2.Text = operand2;

            }

        }



        private void Btn_0_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += "0";

                label2.Text = operand;

            }

            else

            {

                operand2 += "0";

                label2.Text = operand2;

            }

        }



        private void Btn_dot_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand += ".";

                label2.Text = operand;

            }

            else

            {

                operand2 += ".";

                label2.Text = operand2;

            }

        }



        //더하기 버튼

        private void Btn_add_Click(object sender, EventArgs e)

        {

            my_operator = 1;

            label1.Text = operand + " + "; // label1은 기록을 저장합니다

            label2.Text = "";              // label2는 현재 입력한 값을 저장합니다.

            operand_check = true;

        }



        //빼기 버튼

        private void Btn_sub_Click(object sender, EventArgs e)

        {

            my_operator = 2;

            label1.Text = operand + " - ";

            label2.Text = "";

            operand_check = true;

        }



        //곱하기 버튼

        private void Btn_mul_Click(object sender, EventArgs e)

        {

            my_operator = 3;

            label1.Text = operand + " x ";

            label2.Text = "";

            operand_check = true;

        }



        //나누기 버튼

        private void Btn_div_Click(object sender, EventArgs e)

        {

            my_operator = 4;

            label1.Text = operand + " / ";

            label2.Text = "";

            operand_check = true;

        }



        //나머지 버튼

        private void Btn_remain_Click(object sender, EventArgs e)

        {

            my_operator = 5;

            label1.Text = operand + " % ";

            label2.Text = "";

            operand_check = true;

        }



        //결과 버튼

        private void Btn_result_Click(object sender, EventArgs e)

        {

            double num_operand = System.Convert.ToDouble(operand);

            double num_operand2 = System.Convert.ToDouble(operand2);



            switch (my_operator)

            {

                case ADD:

                    result = num_operand + num_operand2;

                    MessageBox.Show("" + result);

                    break;



                case SUB:

                    result = num_operand - num_operand2;

                    MessageBox.Show("" + result);

                    break;



                case MUL:

                    result = num_operand * num_operand2;

                    MessageBox.Show("" + result);

                    break;



                case DIV:

                    result = num_operand / num_operand2;

                    MessageBox.Show("" + result);

                    break;



                case REMAIN:

                    result = num_operand % num_operand2;

                    MessageBox.Show("" + result);

                    break;

            }



            Reset();

        }



        // 전체 항목을 클리어

        private void Btn_clear_Click(object sender, EventArgs e)

        {

            Reset();

        }



        private void Btn_delete_Click(object sender, EventArgs e)

        {

            if (operand_check == false)

            {

                operand = operand.Substring(0, operand.Length - 1);

                label2.Text = operand;

            }

            else

            {

                operand2 = operand2.Substring(0, operand2.Length - 1);

                label2.Text = operand2;

            }

        }



        public void Reset()

        {

            label1.Text = "";

            label2.Text = "";

            operand = "";

            operand2 = "";

            operand_check = false;

        }



        private void Btn_pm_Click(object sender, EventArgs e)

        {

            double temp;

            if (operand_check == false)

            {

                // 양수이면 음수로

                if (System.Convert.ToDouble(operand) >= 0)

                {

                    temp = System.Convert.ToDouble(operand) * -1;

                    operand = temp.ToString();

                }

                // 음수이면 양수로

                else

                {

                    temp = System.Convert.ToDouble(operand) * -1;

                    operand = temp.ToString();

                }

                label2.Text = operand;

            }

            // 위 if문의 if~else처럼 굳이 조건을 나누지 않고 밑에 else에서 바로 * -1을 해줘도 똑같습니다.

            // 이해를 위한 설명!

            else

            {

                temp = System.Convert.ToDouble(operand) * -1;

                operand = temp.ToString();

                label2.Text = operand2;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

