﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0215
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            ArrayTest1 at1 = new ArrayTest1(arr);
            ArrayTest1 at2 = new ArrayTest1();

            at2.sumAvg(arr);
           
            ArrayTest1 at3 = new ArrayTest1();
            
            at3.setArray(arr);
            at3.sumAvg();

            new ArrayTest(arr);*/

            int[,] arr =
                new int[5, 3]
            {
                {100,90,80 },
                {90,90,80},
                {90,70,60},
                {70,50,80},
                {40,70,300},

            };
           /* StudentScore st = new StudentScore(arr[i, 0], arr[i, 1], arr[i, 3]);
            st.calculator();
           */
            StudentScore[] arrSt = new StudentScore[5];
        for (int i=0; i<5; i++)
            {
               arrSt[i] = new StudentScore();
              /*  for(int j=0; j<3; j++)*/
                {
                    arrSt[i].setAllPropperty(
                        arr[i, 0], arr[i, 1], arr[i, 2]);
                   /* if (j == 0)
                    {
                        arrSt[i].Kor = arr[i, j];
                    }
                    else if (j == 1)
                    {
                        arrSt[i].Eng = arr[i, j];
                    }
                    else if (j == 2)
                    {
                        arrSt[i].Math = arr[i, j];
                    }*/
                }
                arrSt[i].calculator();
                   /*  new StudentScore(arr[i, 0], arr[i, 1], arr[i, 2] )
                    .calculator();*/
            }
        }
    }
}
