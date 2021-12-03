using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPKalitimOrnek
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }

        public virtual void Selamlasma()
        {
            //virtual keyword
            Console.WriteLine("Selamüm Aleyküm...");
        }
    }
}