

double [] GenerateArray(int len, int min,int max)
{
    
    double [] mass = new double[len];
    Random rnd= new Random();
    
for ( int i =0 ; i <mass.Length;i++)
{
    
    mass[i]=Math.Round(-42.132 + rnd.NextDouble() * (42.156 + 42.132), 2);;

    
}
return mass;
}

double poisk(double [] mass)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if( max<mass[i]) max=mass[i];
        if(min>mass[i])min=mass[i];

    }

    System.Console.WriteLine("Max = "+max);
    System.Console.WriteLine("Min = "+min);
    System.Console.WriteLine("Разница = " +(min+max));
    return 0;
}


void PrintArray (double [] mass)
{
    for ( int i =0 ; i <mass.Length;i++)
{
    System.Console.WriteLine(mass[i]);
    
    
    

}
System.Console.WriteLine();




}

double [] number = GenerateArray(10,-50,50);
PrintArray(number);
poisk(number);