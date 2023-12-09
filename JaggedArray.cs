using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] EmployeeName = new string[3];
            EmployeeName[0] = "Akhand";
            EmployeeName[1] = "Ankit";
            EmployeeName[2] = "Akhilesh";

            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelor";
            jaggedArray[0][1] = "Master";
            jaggedArray[0][2] = "Doctorate";

            jaggedArray[1][0] = "Bachelor";

            jaggedArray[2][0] = "Bachelor";
            jaggedArray[2][1] = "Master";

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] INArray = jaggedArray[i];
                Console.WriteLine(EmployeeName[i]);
                Console.WriteLine("---------------");
                for (int j = 0; j < INArray.Length; j++)
                {
                    Console.WriteLine(INArray[j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
