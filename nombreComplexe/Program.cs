// See https://aka.ms/new-console-template for more information

using nombreComplexe;

void main()
{
    Console.WriteLine("Affiche nombre complex");
    bool ok1, ok2; 
    double a, b;
    double[] data = new double[4];
    
    ok1 = false;
    ok2 = false;
    while (ok1 != true && ok2 != true)
    {
        try
        {
            Console.Write("Entrez la valeur de la partie réelle : ");
            a = double.Parse(Console.ReadLine());
            data[0] = a;
            Console.Write("Entrez la valeur de la partie imaginaire : ");
            b = double.Parse(Console.ReadLine());
            data[1] = b;
            ok1 = true;
                
            Console.Write("Que vaut la partie réel du second complexe : ");
            a = double.Parse(Console.ReadLine());
            data[2] = a;
            Console.Write("Que vaut la partie imaginaire du second complexe : ");
            b = double.Parse(Console.ReadLine());
            data[3] = b;
            ok2 = true; 
        }
        catch
        {
            Console.WriteLine("Entez des nombres UNIQUEMENT");
        }
    }
    
    Complex calcul = new Complex(data[0], data[1]);
    Complex clx2 = new Complex(data[2], data[3]);
    Console.WriteLine(calcul.AfficheComplex());
    double res = calcul.CalculModule();
    Console.WriteLine(res);
    string test = calcul.Ajoute(clx2);
    Console.WriteLine(test);
    
    Console.Write("Voulez-vous réessayer ? y : ");
    string relance = Console.ReadLine();
    if (relance != "y")
    {
        main();
    }
}
main();
