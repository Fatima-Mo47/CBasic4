namespace C__Basic4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++) { 
            //    Console.WriteLine(i);

            //}
            #endregion

            #region 2-Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= 12; i++) { 
            // Console.WriteLine(num*i);

            //}
            #endregion

            #region 3-Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i < num; i++)
            //{
            //    if (i % 2 == 1)
            //        continue;
            //    Console.WriteLine(i);

            //}


            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine("Enter Power");
            //int.TryParse(Console.ReadLine(), out int power);
            //int result=num;
            //for(int i = 1; i < power; i++)
            //{
            //    result=result*num;
            //}


            //Console.WriteLine(result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("enter marks of five subjects");
            //Console.WriteLine("Subject 1");
            //double.TryParse(Console.ReadLine(), out double m1);
            //Console.WriteLine("Subject 2");
            //double.TryParse(Console.ReadLine(), out double m2);
            //Console.WriteLine("Subject 3");
            //double.TryParse(Console.ReadLine(), out double m3);
            //Console.WriteLine("Subject 4");
            //double.TryParse(Console.ReadLine(), out double m4);
            //Console.WriteLine("Subject 5");
            //double.TryParse(Console.ReadLine(), out double m5);

            //int p = (int)((m1 + m2 + m3 + m4 + m5) / 5);

            //Console.WriteLine($"Total Marks = {m1 + m2 + m3 + m4 + m5}");
            //Console.WriteLine($"Average Marks ={p}");
            //Console.WriteLine($"Percentegr Marks ={p}%");
            #endregion

            #region 6- Write a program to input the month number and print the number of days in that month.
            //Console.Write("Please Enter A Month Number to print number of days in it");
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            //switch (monthNumber)
            //{
            //    case 2:
            //        Console.WriteLine("28 days");
            //        break;
            //    case 4|6|9|11:
            //        Console.WriteLine("30 days");
            //        break;
            //    default:
            //        Console.WriteLine("31 days");
            //        break;
            //}
            #endregion

            #region 7-Write a program to create a Simple Calculator.
            //    string value;
            //    do
            //    {
            //        int res;
            //        Console.Write("Enter first number:");
            //        int num1 = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Enter second number:");
            //        int num2 = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Enter symbol(/,+,-,*):");
            //        string symbol = Console.ReadLine();

            //        switch (symbol)
            //        {
            //            case "+":
            //                res = num1 + num2;
            //                Console.WriteLine("Addition:" + res);
            //                break;
            //            case "-":
            //                res = num1 - num2;
            //                Console.WriteLine("Subtraction:" + res);
            //                break;
            //            case "*":
            //                res = num1 * num2;
            //                Console.WriteLine("Multiplication:" + res);
            //                break;
            //            case "/":
            //                res = num1 / num2;
            //                Console.WriteLine("Division:" + res);
            //                break;
            //            default:
            //                Console.WriteLine("Wrong input");
            //                break;
            //        }
            //        Console.ReadLine();
            //        Console.Write("Do you want to continue(y/n):");
            //        value = Console.ReadLine();
            //    }
            //    while (value == "y" || value == "Y");
            //}
            #endregion

            #region 8- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int n); 

            //int left = n;
            //int rev = 0;
            //while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
            //{
            //    int r = left % 10;
            //    rev = rev * 10 + r;
            //    left = left / 10;  //left = Math.floor(left / 10); 
            //}

            //Console.WriteLine(rev);

            #endregion

            #region 9- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //int a, b, i, j, flag;


            //Console.WriteLine("Enter Starting Number");


            // int.TryParse(Console.ReadLine(), out a);


            //Console.WriteLine("\nEnter Ending Number ");


            //int.TryParse(Console.ReadLine(), out b);




            //for (i = a; i <= b; i++)
            //{


            //    if (i == 1 || i == 0)
            //        continue;


            //    flag = 1;

            //    for (j = 2; j <= i / 2; ++j)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag = 0;
            //            break;
            //        }
            //    }


            //    if (flag == 1)
            //        Console.WriteLine(i);

            #endregion

            #region 10-Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int i = 1, binary = 0;
            //int rem, num;
            //Console.WriteLine("Enter a decimal number");
            //int.TryParse(Console.ReadLine(), out num);
            //while (num != 0)
            //{
            //    rem = num % 2;
            //    num = num / 2;
            //    binary = binary + (rem * i);
            //    i = i * 10;
            //}
            //Console.WriteLine($"Binary Number = {binary}");


            #endregion


        }
    }
    }
