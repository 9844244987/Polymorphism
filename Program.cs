using System;
namespace App{
    abstract class Program1{
        abstract public void Implement(int i,int j);
    }
    class Intermediate:Program1{
        public override void Implement(int i, int j){
           int res=i+j;
           Console.WriteLine(res);
          }
    }
    class Program2{
       public void print(int i)
       {
        Console.WriteLine("the entered number is"+i);
       }
       public void print(double j)
       {
        Console.WriteLine("the entered number is"+j);
       }

       public void  print(float k)
       {
        Console.WriteLine("the entered number is float"+k);
       }
         public static void Main(string[] args) {
            Program2 p2=new Program2();
            Intermediate i2=new Intermediate();
            i2.Implement(1,2);
            p2.print(1);//static polymorphism (Function overloading);
            p2.print(2.3);
            p2.print(2.333345f);

        }
    }
}
