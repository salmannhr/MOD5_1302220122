using System.Security.Cryptography.X509Certificates;
using System.Numerics;
namespace modul5_1302220122
{
    internal class Program
    {
        public class penjumlahan<T>
        {
            public T jumlahTigaAngka<T>(T A, T B, T C) where T : IAdditionOperators<T, T, T>
            {
                return A + B + C;
            }
        }
        static void Main(string[] args)
        {
            penjumlahan<float> jumlahTigaAngka = new penjumlahan<float>();
            Console.WriteLine(jumlahTigaAngka.jumlahTigaAngka(13, 02, 22));
        }
    }
}