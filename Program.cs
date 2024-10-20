using System;

class Program
{
    static void Main()
    {
        // إدخال الأرقام من المستخدم
        Console.Write("num1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("num2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // إدخال العملية
        Console.Write("select op(+, -, *, /): ");
        string operation = Console.ReadLine();

        double result;

        // تنفيذ العملية الحسابية
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("error 0");
                    return;
                }
                break;
            default:
                Console.WriteLine("error");
                return;
        }

        // عرض النتيجة
        Console.WriteLine($"النتيجة: {num1} {operation} {num2} = {result}");
    }
}