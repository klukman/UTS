using System;

namespace UTS_1521_Lukman
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();

            dosen.ID = 190302123;
            dosen.Nama = "Kamarudin, M.Kom";
            dosen.NIK = 987654;
            dosen.Gender = "Laki-laki";
            dosen.Couser = "Pemrograman";

            Console.WriteLine("NO \tID \t\tNama \t\t\tNIK \tGender \t\tCouser");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. \t{0} \t{1} \t{2} \t{3} \t{4} \n", dosen.ID, dosen.Nama, dosen.NIK, dosen.Gender, dosen.Couser );

            Dosen dosen2 = new Dosen();

            Console.WriteLine("Nama:");
            dosen2.Nama = Console.ReadLine();
            Console.WriteLine("NIK");
            dosen2.NIK = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NO \tID \t\tNama \t\tNIK \tGender \t\tCouser");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. \t{0} \t{1} \t{2} \t{3} \t{4}", dosen.ID, dosen.Nama, dosen.NIK, dosen.Gender, dosen.Couser);
            Console.WriteLine("2. \t0 \t\t{0} \t\t{1} \t0 \t\t0 \n", dosen2.Nama, dosen2.NIK);

            Console.WriteLine("Couser:");
            dosen2.Couser = Console.ReadLine();
            Console.WriteLine("NO \tID \t\tNama \t\tNIK \tGender \t\tCouser");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. \t{0} \t{1} \t{2} \t{3} \t{4}", dosen.ID, dosen.Nama, dosen.NIK, dosen.Gender, dosen.Couser);
            Console.WriteLine("2. \t0 \t\t{0} \t\t{1} \t0 \t\t{2}", dosen2.Nama, dosen2.NIK, dosen2.Couser);

            
            Console.ReadKey();
        }
    }
}

