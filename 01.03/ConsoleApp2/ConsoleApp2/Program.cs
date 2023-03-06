using System;

class Calculator
{
    private int num1;
    private int num2;
    private int result;

    public int Num1
    {
        get { return num1; }
        set { num1 = value; }
    }

    public int Num2
    {
        get { return num2; }
        set { num2 = value; }
    }

    private void Multiply()
    {
        result = num1 * num2;
    }

    public void DisplayResult()
    {
        Multiply();
        Console.WriteLine("Result of multiplication is: " + result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.Write("Enter first number: ");
        calc.Num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        calc.Num2 = Convert.ToInt32(Console.ReadLine());

        calc.DisplayResult();
    }
}
