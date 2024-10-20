using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace c
{
    //Hodisa uchun delegat e'lon qilish
public delegate void misol(double t);
//Hodisaga ega sinf eloni
public partial  class Form1
{
    
    public event misol hodisa;//hodisa ishga tushirilganda chaqiriladi
    public void button1_Click(double t)
    {
        if(hodisa!=null)
        hodisa(t);
    }
}
 class Program
{
    static void Yol(double t)
    {
        double S;
        S=7*t*t*t+2*t*t+5*t+10;
        Console.WriteLine($"S={S}");

    }
    
    static void tezlik(double t)
    {
        double V;
        V=21*t*t+4*t+5;
        Console.WriteLine($"V={V}");
    }
    static void tezlanish(double t)
    {
      double a=42*t+4;
      Console.WriteLine($"a={a}");
    }
    
    [STAThread]
    static void Main(string[] args)
    {
        Form1 evt=new Form1();
        
        
        evt.hodisa+=tezlik;
        evt.hodisa+=tezlanish;
        evt.button1_Click(6);
        Console.WriteLine("");
    }
}
}