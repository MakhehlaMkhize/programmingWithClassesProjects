using System;

class Fraction{
    private int _topNumber;
    private int _bottomNumber;
    
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }
   
    public string GetFractionString()
    {
        string fractionValue = $"{_topNumber}/{_bottomNumber}"; 
        return fractionValue;
    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)_topNumber/(double)_bottomNumber;
        return decimalValue;
    }
}