using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월 입력: ");
            String month = Console.ReadLine();
            String re = "";
            for(int i = 1; i <= 12; i++)
            {
                if (month.Contains(""+i))
                {
                    switch (i)
                    {
                        case 3: case 4:case 5:
                            re = "봄";break;
                        case 6:case 7:case 8:
                            re = "여름";break;
                        case 12:case 1:case 2:
                            re = "겨울";break;
                        case 10:case 11:case 9:
                            re = "가을";break;
                    }
                }
            }
            Console.Write(re);
        }
    }
}
