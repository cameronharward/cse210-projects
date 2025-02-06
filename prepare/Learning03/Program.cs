using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        System.Console.WriteLine(fract1.getFractionString());
        Fraction fract2 = new Fraction(5, 1);
        System.Console.WriteLine(fract2.getNumerator());
        System.Console.WriteLine(fract2.getDenominator());
        Fraction fract3 = new Fraction(3,4);
        System.Console.WriteLine(fract3.getFractionString() + ": " + fract3.getDecimalValue());


    }
}