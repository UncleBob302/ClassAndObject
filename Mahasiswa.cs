using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Mahasiswa
    {
        // properties
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }

        // method
        public void registrasi()
        {
            Console.WriteLine("Nama; {0}", Nama);
            Console.WriteLine("Nim; {0}", Nim);
            Console.WriteLine("Ipk; {0}", Ipk);
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses krs\n", Nama);
        }
    }
}
