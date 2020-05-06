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

            for(int i = 1; i <= 12; i++)
            {
                if (month.Contains(""+i))
                {
                    switch (i)
                    {
                        case 3: case 4:case 5:
                            Console.Write("봄");break;
                        case 6:case 7:case 8:
                            Console.Write("여름"); break;
                        case 10:case 11:case 9:
                            Console.Write("가을"); break;
                        default:
                            Console.Write("겨울"); break;
                    }
                }
            }
        }
    }
}
