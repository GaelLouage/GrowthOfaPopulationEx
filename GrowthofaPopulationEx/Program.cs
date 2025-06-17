internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(NbYear(1500, 5, 100, 5000));
        //Console.WriteLine(NbYear(1500000, 2.5, 10000, 2000000));
        //Console.WriteLine(NbYear(1500000, 0.25, 1000, 2000000));
    }
    public static int NbYear(int p0, double percent, int aug, int p)
    {
        // your code
        var years = 0;
        var percentage = (double)percent / 100;
        var growth = 0;

        while(growth < p)
        {
            if(growth < p)
            {
                growth = (int)(p0 + p0 * percentage + aug);
                p0 = (int)growth;
                years++;
            }
        }
        return years;
    }
}