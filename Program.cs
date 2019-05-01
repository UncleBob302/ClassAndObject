using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu
            saya.Nim = "12345";
            saya.Nama = "Kamaruddin";
            saya.Ipk = 4;

            kamu.Nim = "22834";
            kamu.Nama = "Iqbal";
            kamu.Ipk = 3.80f;

            // memanggil method registrasi dan isi krs
            saya.registrasi();
            saya.IsiKrs();

            kamu.registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
