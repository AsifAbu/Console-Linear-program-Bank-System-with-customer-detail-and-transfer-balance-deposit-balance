using System;

namespace ClassLibrary1
{
    public class Tringle
    {
        int x, y, z;
        public Tringle()
        {
        }
        public Tringle(int x,int y,int z)
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
        public void SetX(int a)
        {
            this.x = a;
        }
        public void SetY(int b)
        {
            this.y = b;
        }
        public void SetZ(int c)
        {
            this.z = c;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public int GetZ()
        {
            return z;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("The X Is: " + x);
            System.Console.WriteLine("The Y Is: " + y);
            System.Console.WriteLine("The Z Is: " + z);
       } 
       public void TestTringle(int a,int b,int c)
       {
           if (a==b)
           {
               if(b==c)
               {
                   System.Console.WriteLine("Three Side Is Equals.");
               }
               else
               {
                   System.Console.WriteLine("A and B Side Is Equals.");
               }
           }
           else if (a==c)
           {
               System.Console.WriteLine("A and C Is Equal.");
           }
           else if(b==c)
           {
               System.Console.WriteLine("B and C Is Equal.");
           }
           else
               System.Console.WriteLine("No Equal Side.");
       }
    }
}
