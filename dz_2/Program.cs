using System;

namespace dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            if (a != b)
            {
                if (a > b)
                    System.Console.WriteLine(a);
                System.Console.WriteLine(b = a);
            }
           else if (a == b)
            {
                System.Console.WriteLine(a = 0 );
                System.Console.WriteLine(b = 0 );
            }
            else
            {
                System.Console.WriteLine(a = b);
                System.Console.WriteLine(b);
            }
           
            // 2
            int operand1 = Convert.ToInt16(Console.ReadLine());
            int operand2 = Convert.ToInt16(Console.ReadLine());
            char sing = Convert.ToChar(Console.ReadLine());
            switch (sing)
            {
                case '+':
                    Console.WriteLine(operand1 + operand2);
                    break;
                case '-':
                    Console.WriteLine(operand1 - operand2);
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("We can not devide in zero");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                case '*':
                    Console.WriteLine(operand1 * operand2);
                    break;
                case '%':
                    Console.WriteLine(operand1 % operand2);
                    break;
                default:
                    Console.WriteLine("Input correct value");
                    break;
            }
            // 3
            int operand = Convert.ToInt16(Console.ReadLine());
            if (operand >= 0 && operand <= 14)
            {
                Console.WriteLine("In interval [14-0] the number is related");
            }
            else if (operand >= 15 && operand <= 35)
            {
                Console.WriteLine("In interval [15-35] the number is related");

            }
            else if (operand >= 26 && operand <= 50)
            {
                Console.WriteLine("In interval [26-50] the number is related");

            }
            else if (operand >= 50 && operand <= 100)
            {
                Console.WriteLine("In interval [50-100] the number is related");

            }
            else
            {
                Console.WriteLine("In none of interval  the number related");

            }
            // 4
            int cost = Convert.ToInt32(Console.ReadLine());
            if (cost >= 500)
            {
                Console.WriteLine((cost * 97) / 100);
            }
            else if (cost >= 1000)
            {
                Console.WriteLine((cost * 95) / 100);
            }
            else
            {
                Console.WriteLine(cost);
            }
            // 5
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            int fourth = Convert.ToInt32(Console.ReadLine());
            if (first == second && third == fourth && first == fourth)
            {
                Console.WriteLine(Math.Pow(first, 4));
            }
            else if (first < second && second < third && third < fourth)
            {
                Console.WriteLine("The growing sequence");
            }
            else
            {
                int elem1 = Math.Min(first, second);
                int elem2 = Math.Min(third, fourth);
                if (elem1 < elem2)
                {
                    Console.WriteLine("The min element is " + elem1);

                }
                else if (elem1 > elem2)
                {
                    Console.WriteLine("The min element is " + elem2);
                }
                else
                {
                    Console.WriteLine("The mins element are " + elem1);
                }
            }
            // 6
            int first_elem = Convert.ToInt32(Console.ReadLine());
            int second_elem = Convert.ToInt32(Console.ReadLine());
            int third_elem = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[3] { first_elem, second_elem, third_elem };
            Array.Sort(numbers);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(' ' + numbers[i]);
            }
        }
}

}
