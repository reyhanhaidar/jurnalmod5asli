// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


class Penjumlahan
{
    static void  PenjumlahanTigaAngka<T>(T a, T b, T c){
        dynamic q = a;
        dynamic r = b;
        dynamic g = c;
        dynamic jumlah = q + r + g;
    }
    public void Main(string[] args)
    {
        
        double q = Console.Read();
        float r = Console.Read();
        long g = Console.Read();
        Console.WriteLine("Masukan angka double " + q);
        Console.WriteLine("Masukan angka float" + r);
        Console.WriteLine("Masukan angka long" + g);
        PenjumlahanTigaAngka(q, r, g);

    }
}


