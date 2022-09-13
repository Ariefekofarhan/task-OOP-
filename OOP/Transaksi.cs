using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Transaksi 
    {
        public virtual void Status(string Name)
        {
            Console.WriteLine(Name + "proses mengirim ke lokasi");
        }

        public void Expedisi(string Name)
        {
            Console.WriteLine("Jasa :" + Name);
        }

    }
}
