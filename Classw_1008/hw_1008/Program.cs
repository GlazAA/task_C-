using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// ���� ���� ����� � ����� �� c = (a + b) * (a - b)
/*
namespace Classw_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("������� ������ �����: ");
            int a = Console.Readline(Console.ReadLine());

            Console.Write("������� ������ �����: ");
            int b = Console.Readline(Console.ReadLine());

            int c = (a + b) * (a - b);
            Console.WriteLine($"��������� ���������: {c}");
            Console.ReadKey();
        }
    }
}
*/

// �����������
/*
class Calculator
{
    public double Calculate(double num1, double num2, char operation)
    {
        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("�� ���� ������ ������");
                break;

            default:
                Console.WriteLine("������");
                break;
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("������ �����: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("������� ������ �����:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("������� �������� (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        double result = calculator.Calculate(number1, number2, operation);

        if (operation == '+' || operation == '-' || operation == '*' || (operation == '/' && number2 != 0))
        {
            Console.WriteLine("��������� = " + result);
        }
    }
}
*/



//��������� ��������� �� 5

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i*5);
            i++;
        }
    }



// ��������� ������� �������������� 
/*class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5,8,21,11 };
        int sum = 0;
      
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double avg = (double)sum / numbers.Length;
        Console.WriteLine($"������� �����: {avg}");
    }
}*/

//���������, ������� ��������� ������ ����� ����� � ������� ������������ 








