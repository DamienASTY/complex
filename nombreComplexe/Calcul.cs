namespace nombreComplexe;

public class Complex
{
    private double a;
    private double b;

    public Complex(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public void setA(double a)
    {
        this.a = a;
    }

    public void setB(double b)
    {
        this.b = b;
    }

    public double getA()
    {
        return this.a;
    }

    public double getB()
    {
        return this.b;
    }

    public string AfficheComplex()
    {
        return $"({this.a}{this.b})";
    }

    public double CalculModule()
    {
        double res1 = (this.a * this.a) + (this.b * this.b);
        return Math.Sqrt(res1);
    }

    public string Ajoute(Complex nb)
    {
        return $"Le premier complexe devient : ({this.a + nb.getA()} ; {this.b + nb.getB()})\nAprès l'ajout du second complexe";
    }
}