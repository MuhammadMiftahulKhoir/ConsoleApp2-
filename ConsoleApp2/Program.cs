using System;

namespace BiodataOtomatis
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Variabel Langsung Diisi (Tidak Perlu Input) ---

            string nama = "Muhammad Miftahul Khoir";
            string programStudi = "Teknik Informatika";
            string namaKampus = "Universitas Pelita Bangsa";
            string hobi = "main bola";

            // --- Menampilkan Output ---

            Console.WriteLine("=====================================");
            Console.WriteLine("          DATA DIRI (OTOMATIS)       ");
            Console.WriteLine("=====================================");

            // Output 1
            Console.WriteLine($"\nHalo, nama saya adalah {nama}");

            // Output 2
            Console.WriteLine($"Saya kuliah pada jurusan {programStudi} di {namaKampus}");

            // Output 3
            Console.WriteLine($"Saya memiliki hobi {hobi}");

            Console.WriteLine("\n=====================================");

            // Menunggu input sebelum program ditutup
            Console.WriteLine("Tekan tombol apa saja untuk menutup program...");
            Console.ReadKey();
        }
    }
}