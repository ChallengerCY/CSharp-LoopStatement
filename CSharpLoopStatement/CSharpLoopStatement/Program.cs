using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLoopStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //for循环
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    //break;//跳出当前循环
                    continue;//跳出本次循环
                }
                Console.WriteLine(i);
            }
            //foreach语句
            //必须使用了IEumerable接口才能用foreach
            List<int> listInt = new List<int> {1,2,3};
            foreach(var intInList in listInt)
            {
                Console.WriteLine(intInList);
            }
            //while语句
            int n = 1;
            while (n++ < 6)
            {
                Console.WriteLine("n is {0}", n);
            }
            //do while 
            do{
                //不管什么语句先执行一遍，比while多运行一次
            }while(false);

            Console.ReadLine();
        }
    }
}
