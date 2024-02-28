using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen dört sayı girin:");

        // Kullanıcıdan dört sayıyı giriş olarak alın
        Console.Write("1. Sayıyı girin: ");
        int sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("3. Sayıyı girin: ");
        int sayi3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("4. Sayıyı girin: ");
        inte sayi4 = Convert.ToDouble(Console.ReadLine());

        // Dört sayının ortalamasını hesaplayın
        int ortalama = (sayi1 + sayi2 + sayi3 + sayi4) / 4;

        // Ortalamayı ekrana yazdırın
        Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);
    }
}

