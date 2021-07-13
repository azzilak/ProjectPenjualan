using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program 
    {
        // deklarasi objek collection untuk menampung objek penjualan

        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "RESPONSI PEMROGRAMAN";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.Clear();
            int kodeID;
            string tanggal, nama, kategori1;
            string kategori2 = "error";
            int total;

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota       : ");
            kodeID = int.Parse(Console.ReadLine());

            Console.Write("Tanggal    : ");
            tanggal = Console.ReadLine();

            Console.Write("Customer    : ");
            nama = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            kategori1 = Console.ReadLine();

            Console.Write("Total Nota : ");
            total = int.Parse(Console.ReadLine());

            if (kategori1 == "Tunai" || kategori1 == "T")
            {
                kategori2 = "Tunai";
            }
            if (kategori1 == "K" || kategori1 == "k")
            {
                kategori2 = "kredit";
            }
            daftarPenjualan.Add(new Penjualan() { Code = kodeID, Tanggal = tanggal, Nama = nama, Jenis = kategori2, Total = total });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.Clear();
            int delete;
            bool k = false;
            Console.WriteLine("Hapus data Penjual");
            Console.WriteLine("");
            Console.Write("Nota : ");
            delete = int.Parse(Console.ReadLine());
            int x = 0; 
            foreach (Penjualan daftar in daftarPenjualan)
            {
                if (delete == daftar.Code)
                {
                    daftarPenjualan.RemoveAt(x);
                    k = true;
                    break;
                }
                x++;
            }
            if (k)
            {
                Console.WriteLine("Data penjualan berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Nota tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");
            int no = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, daftar.Code, daftar.Tanggal, daftar.Nama, daftar.Jenis, daftar.Total);
                no++;
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}