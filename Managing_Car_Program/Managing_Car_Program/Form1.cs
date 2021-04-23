using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Datamanger.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar() { parkingSpot=1, 
            //    carNumber="30고9484",
            //driverName = "이동준",
            //phoneNumber="010-2940-1613",
            //parkingTime = DateTime.Now});

            dataGridView1.DataSource = Datamanger.Cars;
            textBox1.Text = Datamanger.Cars[0].parkingSpot.ToString();
            textBox2.Text = Datamanger.Cars[0].carNumber.ToString();
            textBox3.Text = Datamanger.Cars[0].driverName.ToString();
            textBox4.Text = Datamanger.Cars[0].phoneNumber.ToString();

            //cars.Add(new ParkingCar());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : "
                + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") +
                "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("주차 버튼 클릭");
            //공간번호
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차공간 을 입력하시오");
                writeLog("주차공간 입력");

            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("차번호를 입력하시오");
                writeLog("차번호 입력");
            }
            else
            {
                try
                {

                    //본격적 입력 하는 작업 
                    ParkingCar Car = Datamanger.Cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (Car.carNumber.Trim() != "")//이미 차정보가 저장되있음
                    {
                        MessageBox.Show("해당 공간에는 이미 차가 있습니다");
                        writeLog("해당공간에는 이미 차가있습니다.");
                    }
                    else//차정보가 없음
                    {


                        Car.parkingSpot = int.Parse(textBox1.Text);
                        Car.carNumber = textBox2.Text;
                        Car.driverName = textBox3.Text;
                        Car.phoneNumber = textBox4.Text;
                        Car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datamanger.Cars;
                        Datamanger.Save();

                        string contens = $"주차공간 {textBox1.Text}에 {textBox2.Text}자동 추가함";
                        MessageBox.Show(contens);
                        writeLog(contens, DateTime.Now.ToString("yyyy_MM_dd"));



                    }
                }
                catch (Exception ex)
                {
                    string contens = "주차안됨" + textBox1.Text;
                    MessageBox.Show(contens);
                    writeLog(contens);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차 버튼 클릭");
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차공간 번호를 입력해주세요");
                return;
            }
            try
            {
                for (int i = 0; i < Datamanger.Cars.Count; i++)
                {
                    if (Datamanger.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if (Datamanger.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("아직 차없음");
                            writeLog("아직 차없음");
                            break;
                        }
                        else
                        {
                            Datamanger.Cars[i].carNumber = "";
                            Datamanger.Cars[i].driverName = "";
                            Datamanger.Cars[i].phoneNumber = "";
                            Datamanger.Cars[i].parkingTime = DateTime.Now;
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text} 차량 출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; // dataGridView1의 데이터를 한번 지워주고
                            dataGridView1.DataSource = Datamanger.Cars; //다시 리셋
                            Datamanger.Save();
                            break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("출차 안됨");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                try
                {
                    //writeLog("3번 버튼 클릭");
                    //writeLog("3번 버튼 클릭",DateTime.Now.ToString("yyyy_MM_dd"));
                    writeLog("조회버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
                    int parkingSpot = int.Parse(textBox5.Text);
                    string parkedCar = lookUpParkingFunction(parkingSpot);
                    string contents = string.Empty;
                    if (parkedCar.Trim() != "")
                    {
                        contents = $"주차공간 {textBox5.Text}에 주차된 차는 {parkedCar}입니다.";
                    }
                    else
                    {
                        contents = $"주차공간 {textBox5.Text}에 주차된 차가 없습니다.";
                    }
                    writeLog(contents);
                    MessageBox.Show(contents);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("주차 공간 번호가 이상합니다." + textBox5.Text);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }


            }
            private string lookUpParkingFunction(int parkingSpot) //조회하는 함수(연계 필요 데이터 식별)
            {
                try
                {
                    // 공간 번호를 받는다, Single로 조회를 한다.(ver1)
                    //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot == parkingSpot);
                    //string ParkedCarNumber = car.CarNumber;
                    //return ParkedCarNumber;

                    //ver2
                    // foreach문으로 조회한다.(single이 어려울 경우)
                    string ParkedCarNumber = "";
                    foreach (var item in Datamanger.Cars)
                    {
                        if (item.parkingSpot == parkingSpot)
                            ParkedCarNumber = item.carNumber;
                    }
                    return ParkedCarNumber;

                }
                catch (Exception e)
                {
                    throw;
                }
            }
        private void writeLog(string contents)
        {
            //int a = 1;
            //MessageBox.Show(a.ToString("00")); 
            //01이라고 출력됨. 3자리 이상 입력하면 그대로 출력됨
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            //옛날 것이 가장 위에 올라가는 방식
            //새로운 내용이 뒤에 추가가 되어서, 새로운 내용을 보려면
            //밑으로 내려가야 함!
            //listBox1.Items.Add(logContens);

            //새로운 것이 가장 위에 올라가는 방식
            //새로운 내용이 가장 앞에 있게 되는 것!
            listBox1.Items.Insert(0, logContens);
            //List<int> list = new List<int>();
            //list.Insert(0, 1);
            Datamanger.printLog(logContens);
        }
        //writeLog 함수를 오버로딩
        private void writeLog(string contents, string date)
        {

            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            listBox1.Items.Insert(0, logContens);
            Datamanger.printLog(logContens, date);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

            }
        }

       
    }
}
