using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloooWorld
{
    public class calculate
    {
         public void AditionOfTwoNumbers()

        {
            Console.WriteLine("please enter 1st numbeer"); 
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("addition is "+firstNum + SecondNum);
            //int add =firstNum + SecondNum;  
            //Console.WriteLine("addition is " +add); 

        }
    }
}
