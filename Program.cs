using System;

namespace calculator
{
    class program{
        static void Main(string[] args){
            Console.WriteLine("Kalkulator");
            int angka1 = 0;
            int angka2 = 0;
            
            Console.WriteLine("=====================");
            Console.Write("Masukkan angka : ");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Operator : ");
            switch(Console.ReadLine()){
                case "+":
                    Console.Write("Masukkan angka : ");
                    angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=====================");
                    var totalTambah = angka1 + angka2;
                    Console.WriteLine("Hasil : "+ totalTambah);
                    break;
                case "-":
                    Console.Write("Masukkan angka : ");
                    angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=====================");
                    var totalKurang = angka1 - angka2;
                    Console.WriteLine("Hasil : "+ totalKurang);
                    break;
                case "/":
                    Console.Write("Masukkan angka : ");
                    angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=====================");
                    double totalBagi = (double)angka1 / angka2;
                    Console.WriteLine("Hasil : "+ totalBagi);
                    break;
                case "*":
                    Console.Write("Masukkan angka : ");
                    angka2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=====================");
                    var totalKali = angka1 * angka2;
                    Console.WriteLine("Hasil : "+ totalKali);
                    break;   
            }
        } 
    }
}