using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Barang barang = new Barang(1, "Shopee", 100);
            barang.Harga(1000);
            barang.Jumlah(10);
            barang.Status("Shopee");
            barang.Expedisi("Sicepat");

            Console.WriteLine();
        }

    }
}
