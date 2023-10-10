using System;

namespace kalkulator
{
    /// <summary>
    /// Program untuk melakukan operasi perhitungan sederhana.
    /// </summary>
    class Program
    {
        // Variabel-variabel publik untuk menyimpan input dan operator
        public static double num1;
        public static double num2;
        public static string operat;

        /// <summary>
        /// Method untuk menampilkan hasil perhitungan.
        /// </summary>
        /// <param name="val">Hasil Perhitungan</param>
        static void answer(double val)
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0} {1} {2} is equal to {3}", num1, operat, num2, val));
            Console.ReadKey();
        }
        /// <summary>
        /// Method untuk menampilkan pesan kesalahan jika input tidak valid.
        /// </summary>
        /// <param name="type">Tipe input yang tidak valid</param>
        static void invalid(string type)
        {
            Console.Clear();
            Console.Write("Invalid {0}", type);
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Method main aplikasi.
        /// </summary>
        /// <param name="args">Argumen baris perintah (tidak digunakan).</param>
        static void Main(string[] args)
        {
        Start:
            string yorn;
        Input1:
            // Meminta input pertama
            Console.Write("Please input a number: ");
            if (Double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Clear();
            }
            else
            {
                // Menampilkan pesan kesalahan jika input tidak valid
                invalid("number");
                goto Input1;
            }
        Input2:
            // Meminta input kedua
            Console.Write("Please input another number: ");
            if (Double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Clear();
            }
            else
            {
                // Menampilkan pesan kesalahan jika input tidak valid
                invalid("number");
                goto Input2;
            }
        Oper:
            // Meminta Operator
            Console.Write("Please input the operator to use (+ - * / %) : ");
            operat = Convert.ToString(Console.ReadLine());
            switch (operat)
            {
                case "+":
                    answer(num1 + num2);
                    break;
                case "-":
                    answer(num1 - num2);
                    break;
                case "*":
                    answer(num1 * num2);
                    break;
                case "/":
                    answer(num1 / num2);
                    break;
                case "%":
                    answer(num1 % num2);
                    break;
                default:
                    // Menampilkan pesan kesalahan jika operator tidak valid
                    invalid("operator");
                    goto Oper;
            }
            Console.Clear();
            // Meminta pengguna apakah ingin melakukan perhitungan lagi
            Console.Write("Do you want to do another calculation? Y or N\n");
            yorn = Convert.ToString(Console.ReadLine());
            if (yorn == "Y")
            {
                Console.Clear();
                goto Start;
            }
            else
            {
                  // Keluar dari aplikasi jika tidak ingin melakukan perhitungan lagi
            }
        }
    }
}

