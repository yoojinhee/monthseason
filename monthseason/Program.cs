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
                    if (i <= 5) { Console.Write("봄"); break; }
                    if(i<=8) {Console.Write("여름"); break; }
                    if (i<=11) {Console.Write("가을"); break; }
                    else Console.Write("겨울");
                }
            }
        }
    }
}
