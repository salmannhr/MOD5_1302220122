using System.Security.Cryptography.X509Certificates;
using System.Numerics;
using System.Net.Http.Headers;
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
            SimpeDataBase<float> Data = new SimpeDataBase<float>();
            Data.AddNewData(13);
            Data.AddNewData(02);
            Data.AddNewData(22);
            Data.PrintData();
        }

        public class SimpeDataBase<T>
        {
            private List<T> storeData { get; set; }
            private List<DateTime> InputDates { get; set; }

            public SimpeDataBase()
            {
                storeData = new List<T>();
                InputDates = new List<DateTime>();
            }

            public void AddNewData(T List)
            {
                storeData.Add(List);
                InputDates.Add (DateTime.Now);
            }
            public void PrintData()
            {
                for(int i = 0;  i < storeData.Count; i++)
                {
                    Console.WriteLine("Data " + i +"berisi: " + storeData[i] + "yang disimpan pada" + InputDates[i]);

                }
            }
        }
    }
}