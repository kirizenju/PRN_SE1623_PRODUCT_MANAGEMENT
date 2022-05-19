namespace fptedu.se1623;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello World....");
        int x = 10,y = 20;
        string name;
        var salary = 10.5;
        dynamic fullName = 10;
        Console.WriteLine(salary.GetType);
        Console.WriteLine($"sum of a={x} and b={y} is:{Sum(x, y)}");
        Console.ReadLine();
    }
    public  static int Sum(int a,int b)
    {
        return a + b;
    }
}