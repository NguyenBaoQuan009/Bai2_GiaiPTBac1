using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        double x;
        Console.WriteLine("nhap so a ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap so b ");
        b =Convert.ToInt32(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinbh vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

        }
        else
        {
            x = (double)-b / a;
            Console.WriteLine("Phuong trinh co nghiem" + x);
        }
    }
}