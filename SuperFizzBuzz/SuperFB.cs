using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFizzBuzz
{
    public class SuperFB
    {
        private List<int> list;
        private int rangeMin, rangeMax;
        private string token1, token2, token3;
        private int div1, div2, div3;

        public List<int> List {
            get { return list; }
            set { list = value; }
        }
        public int RangeMin
        {
            get { return rangeMin; }
            set { RangeMin = value; }
        }
        public int RangeMax
        {
            get { return rangeMax; }
            set { RangeMax = value; }
        }
        public string Token1
        {
            get { return token1; }
            set { token1 = value; }
        }
        public string Token2
        {
            get { return token2; }
            set { token2 = value; }
        }
        public string Token3
        {
            get { return token3; }
            set { token3 = value; }
        }

        public SuperFB(int Amount)
        {
            list = new List<int>(Amount);
        }

        public SuperFB(int? RangeMin, int? RangeMax, 
            string Token1, string Token2, string Token3,
            int Div1, int Div2, int Div3)
        {
            int amount = (int)RangeMax - (int)RangeMin + 1;
            list = new List<int>(amount);
            rangeMin = (int)RangeMin;
            rangeMax = (int)RangeMax;
            token1 = Token1;
            token2 = Token2;
            token3 = Token3;
            div1 = Div1;
            div2 = Div2;
            div3 = Div3;
        }

        public SuperFB(List<int> list, string Token1, string Token2, string Token3)
        {
            foreach (int i in list)
            {
                list.Add(i);
            }
            token1 = Token1;
            token2 = Token2;
            token3 = Token3;
        }

        public void PrintListBasic()
        {
            for ( int i = 1; i <= list.Capacity; i++ )
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        public void PrintListRange()
        {
            for (int i = (int)rangeMin; i <= rangeMax; i++)
            {
                bool fizz = i % div1 == 0;
                bool buzz = i % div2 == 0;
                bool bazz = i % div3 == 0;
                if (fizz && buzz && bazz)
                    Console.WriteLine(token1 + token2 + token3);
                else if (fizz && buzz)
                    Console.WriteLine(token1 + token2);
                else if (fizz && bazz)
                    Console.WriteLine(token1 + token3);
                else if (buzz && bazz)
                    Console.WriteLine(token2 + token3);
                else if (fizz)
                    Console.WriteLine(token1);
                else if (buzz)
                    Console.WriteLine(token2);
                else if (bazz)
                    Console.WriteLine(token3);
                else
                    Console.WriteLine(i);
            }
        }

        public void PrintListSequential(List<int> list)
        {
            foreach (int i in list)
            {
                bool req1 = i % div1 == 0;
                bool req2 = i % div2 == 0;
                bool req3 = i % div3 == 0;
                if (req1 && req2 && req3)
                    Console.WriteLine(token1 + token2 + token3);
                else if (req1 && req2)
                    Console.WriteLine(token1 + token2);
                else if (req1 && req3)
                    Console.WriteLine(token1 + token3);
                else if (req2 && req3)
                    Console.WriteLine(token2 + token3);
                else if (req1)
                    Console.WriteLine(token1);
                else if (req2)
                    Console.WriteLine(token2);
                else if (req3)
                    Console.WriteLine(token3);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
