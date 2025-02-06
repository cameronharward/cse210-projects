using System.Dynamic;

class Fraction{
    private int _numerator;
    private int _denominator;

    public Fraction(){
        _numerator = 1;
        _denominator = 2;
    }
    public Fraction(int num, int den){
        this._numerator = num;
        this._denominator = den;
    }

    public int getNumerator(){
        return _numerator;
    }
    public int getDenominator(){
        return _denominator;
    }
    public void setNumerator(int num){
        _numerator = num;
    }
    public void setDenominator(int den){
        _denominator = den;
    }
    public string getFractionString(){
        return $"{_numerator}/{_denominator}";
    }
    public double getDecimalValue(){
        return _numerator / Convert.ToDouble(_denominator);
    }
}