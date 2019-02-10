using ClassLibrary1;
using ClassLibrary2;

namespace ConsoleApplication1
{
    class Sample
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student("Asif", "16-32595-2", "CSSE", 3.50f);

            //Student s1 = new Student();
            //System.Console.WriteLine("First Type Your Name: ");
            //s1.SetName(System.Console.ReadLine());
            //System.Console.WriteLine("Then Type Your ID: ");
            //s1.SetId(System.Console.ReadLine());
            //System.Console.WriteLine("Then Type Your Department: ");
            //s1.SetDepartment(System.Console.ReadLine());
            //System.Console.WriteLine("Then Type Your CGPA: ");
            //s1.SetCgpa(float.Parse(System.Console.ReadLine()));
            //s1.ShowInfo();

            //Tringle a = new Tringle();
            //System.Console.WriteLine("\n\nType X, Y, Z Value: ");
            //a.SetX(int.Parse(System.Console.ReadLine()));
            //a.SetY(int.Parse(System.Console.ReadLine()));
            //a.SetZ(int.Parse(System.Console.ReadLine()));
            //a.ShowInfo();
            //a.TestTringle(a.GetX(),a.GetY(),a.GetZ());
            
            Account acc = new Account();
            System.Console.WriteLine("\n\nType Your Account Name : ");
            acc.SetAccountName(System.Console.ReadLine());
            System.Console.WriteLine("Type Your Account ID : ");
            acc.SetAccountId(System.Console.ReadLine());
            System.Console.WriteLine("Type Your Current Balance : ");
            acc.SetBalnce(double.Parse(System.Console.ReadLine()));
            acc.ShowAll();

            System.Console.WriteLine("If You Want To Deposit Press '1' else Any Key To Move On.");
            int dd=(int.Parse(System.Console.ReadLine()));
            if (dd == 1)
            {
                System.Console.WriteLine("Type How Much Money You Want To Deposit : ");
                acc.Deposit(double.Parse(System.Console.ReadLine()));
            }
            System.Console.WriteLine("If You Want To Withdraw Press '1' else Any Key To Move On.");
            int ss = (int.Parse(System.Console.ReadLine()));
            if (ss == 1)
            {
                System.Console.WriteLine("Type How Much Money You Want To Withdraw : ");
                acc.Withdraw(int.Parse(System.Console.ReadLine()));
                acc.ShowAll();
            }
            System.Console.ReadKey();
        }
    }
}