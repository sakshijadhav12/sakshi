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
           
            Console.WriteLine(" Addition\n please enter 1st numbeer");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("addition is " + firstNum + SecondNum);
            int add =firstNum + SecondNum;  
            Console.WriteLine("addition is " +add); 

        }
        public void SubtractionOfTwoNumbers()

        {
            
            Console.WriteLine("Subtraction\n please enter 1st numbeer");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int sub = firstNum - SecondNum;
            Console.WriteLine("Subtraction is " + sub);
            //Console.WriteLine("subtraction is " + firstNum - SecondNum);
        }
        public void MultiplicationOfTwoNumbers()

        {    
            Console.WriteLine("Multiplication\n please enter 1st numbeer");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int Mul = firstNum * SecondNum;
            Console.WriteLine("Multiplication  is " + Mul);
            //Console.WriteLine("subtraction is " + firstNum * SecondNum);
        }
        public void DivisionOfTwoNumbers()

        {   
            Console.WriteLine("Division\n please enter 1st numbeer");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int div = firstNum  / SecondNum;
            Console.WriteLine("division is  " + div);
            //Console.WriteLine("subtraction i " + firstNum % SecondNum);
        }



    }
}
