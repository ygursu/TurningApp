using System;
class BinaryConverter
{
    static void Main()
    {
        int num;
        Console.Write("Sayıyı Girin : ");
        num = int.Parse(Console.ReadLine());
        int kSayi;
        string rem = "";
        while (num >= 1)
        {
            kSayi = num / 2;
            rem += (num % 2).ToString();
            num = kSayi;
        }
        string bin = "";
        for (int i = rem.Length - 1; i >= 0; i--)
        {
            bin = bin + rem[i];
        }
        Console.WriteLine("Binary değeri: {0}", bin);
        Console.Read();
    }
}

