using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;


public class RationalNumber { 

    public int numerator { get; private set; }
    public int denominator { get; private set; }
    private int FindGCD(int a, int b)
    {
        return b == 0 ? a : FindGCD(b, a % b);
    }

    private void Simplify()
    {
        int gcd = FindGCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Division by zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }
    //test
    public string ToString()
    {
        if (denominator == 1) 
        {
            return numerator.ToString();
        }
        else 
        {
            return numerator + "/" + denominator;
        }
    }
    //test
    public static RationalNumber operator +(RationalNumber rationalNumber, int num)
    {
        int newNumerator = rationalNumber.numerator + num * rationalNumber.denominator;
        int newDenominator = rationalNumber.denominator; 
        return new RationalNumber(newNumerator, newDenominator);
    }
    //test

    public static RationalNumber operator -(RationalNumber rationumber, int num)
    {
        int newNumerator = rationumber.numerator - num * rationumber.denominator;
        return new RationalNumber(newNumerator, rationumber.denominator);
    }
    //test
    public static RationalNumber operator *(RationalNumber rationumber, int num)
    {
        int newNumerator1 = rationumber.numerator * num;
        int newNumerator2 = rationumber.denominator;
        return new RationalNumber(newNumerator1, newNumerator2);
    }
    //test
    public static RationalNumber operator /(RationalNumber rationumber, int num)
    {
        if (num == 0)
        {
            throw new ArgumentException("Division by zero.");
        }
        int newNumerator1 = rationumber.numerator;
        int newDenominator = rationumber.denominator * num;
        return new RationalNumber(newNumerator1, newDenominator);
    }
    //test
    public static RationalNumber operator -(RationalNumber rationalNumber)
    {
        return new RationalNumber(-rationalNumber.numerator, rationalNumber.denominator);
    }
    public static bool operator ==(RationalNumber rationalNumber, RationalNumber myrationalNumber)
    {
        if (rationalNumber.numerator == myrationalNumber.numerator && rationalNumber.denominator == myrationalNumber.denominator)
        {
            return true;
        }
        return false;
    }
    //test
    public static bool operator !=(RationalNumber rationalNumber, RationalNumber myrationalNumber)
    {
        return !(rationalNumber == myrationalNumber);
    }
    //test
    public static bool operator <(RationalNumber rationalNumber, RationalNumber myrationalNumber)
    {
        if (rationalNumber.denominator != 0 && myrationalNumber.denominator != 0)
        {
 
            double fraction1 = (double)rationalNumber.numerator / rationalNumber.denominator;
            double fraction2 = (double)myrationalNumber.numerator / myrationalNumber.denominator;
            if (fraction1 < fraction2) { return true; }
        }
        return false;
    }
    //test
    public static bool operator <=(RationalNumber rationalNumber, RationalNumber myrationalNumber)
    {
        if (rationalNumber.denominator != 0 && myrationalNumber.denominator != 0)
        {

            double fraction1 = (double)rationalNumber.numerator / rationalNumber.denominator;
            double fraction2 = (double)myrationalNumber.numerator / myrationalNumber.denominator;
            if (fraction1 <= fraction2) { return true; }
        }
        return false;
    }
    //test
    public static bool operator >(RationalNumber rationalNumber, RationalNumber myrationalNumber)
    {
        if (rationalNumber.denominator != 0 && myrationalNumber.denominator != 0)
        {
 
            double fraction1 = (double)rationalNumber.numerator / rationalNumber.denominator;
            double fraction2 = (double)myrationalNumber.numerator / myrationalNumber.denominator;
            if (fraction1 > fraction2) { return true; }
        }
        return false;
    }
    //test
    public static bool operator >=(RationalNumber rationalNumber, RationalNumber myrationalNumber)
    {
        if (rationalNumber.denominator != 0 && myrationalNumber.denominator != 0)
        {

            double fraction1 = (double)rationalNumber.numerator / rationalNumber.denominator;
            double fraction2 = (double)myrationalNumber.numerator / myrationalNumber.denominator;
            if (fraction1 >= fraction2) { return true; }
        }
        return false;
    }
}
class Program
{
    static void Main(string[] args)
    {

        var num = new RationalNumber(2, 3);
        num = num + 5;
        Console.WriteLine(num.ToString());  
        //var number = new RationalNumber(9, 0);
        //RationalNumber number = new RationalNumber(5, 2);
        //RationalNumber result = --number;
        //Console.WriteLine(result.numerator +"/"+ result.denominator);
        //RationalNumber answ = new RationalNumber(5,3);
        //bool res = (number >= answ);
        //Console.WriteLine(answ.numerator + "/" + answ.denominator);
        //Console.WriteLine(res);
    }
}
