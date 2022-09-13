using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Barang : Transaksi
    {
        public Barang (int Id, string Name, int Stock )
        {
            this.Id = Id;
            this.Nama = Name;
            this.Stok = Stock;
        }

        public int Id { get; private set; }
        public string Nama { get; private set; }
        public int Stok { get; private set; }

        public void Harga( int Harga)
        {
            Console.WriteLine("Harga" + Harga);
        }

        public void Jumlah(int Stock)
        {
            Console.WriteLine("Jumlah pembelian : " + Stock);
        }

        public override void Status(string Name)
        {
            Console.WriteLine(Name + ": Di proses");
        }
    }
}
