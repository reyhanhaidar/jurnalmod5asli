using System;

public class Penjumlahan
{
         public static T PenjumlahanTigaAngka<T>(T a, T b, T c)
        {
            dynamic q = a;
            dynamic r = b;
            dynamic g = c;
            dynamic jumlah = q + r + g;
            return jumlah;
        }
        
    
}

public class database<T>
{
    private List<T> StoredData;
    private List<DateTime> inputDates;

    public void SimpleDataBase()
    {
        this.StoredData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddnewData(T data)
    {
        StoredData.Add(data);
        inputDates.Add(DateTime.Now);

    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.inputDates.Count; i++)
        {
            Console.WriteLine("Data " + i + "berisi:" + StoredData + ", yang disimpan pada waktu UTC: " + inputDates);
        }
    }

}
class Program
{
    public static void Main(string[] args)
    {
        
        
        
        Console.WriteLine(Penjumlahan.PenjumlahanTigaAngka<int>(13, 02, 21));

    }
}
