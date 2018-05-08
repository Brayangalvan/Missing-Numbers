namespace Missing_Numbers
{
    using Validations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            GetParamts();
        }

        public static void GetParamts()
        {
            Validation validation = new Validation();

            int n = Convert.ToInt32(Console.ReadLine());
            validation.ValidatonSizeVector(n);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            validation.ValidatonSizeVectorAndData(n, arr.Length);

            int m = Convert.ToInt32(Console.ReadLine());
            validation.ValidatonSizeVector(m);

            validation.ValidatonVectors(n, m);

            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            validation.ValidatonSizeVectorAndData(m, brr.Length);
            validation.ValidatonDifferenceBetweenMaximumAndMinimumData(brr);

            int[] result = MissingNumbers(arr, brr);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        public static int[] MissingNumbers(int[] arr, int[] brr)
        {
            int[] result = GetLostNumbers(arr, brr);
            return result.OrderBy(item => item).ToArray();
        }

        public static int[] GetLostNumbers(int[] arr, int[] brr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int contador = 0;

                for (int j = 0; j < brr.Length; j++)
                {
                    if (contador == 0 && arr[i] == brr[j])
                    {
                        brr[j] = 0;
                        contador = 1;
                    }
                }
            }

            return brr.Where(item => item != 0).Distinct().ToArray();
        }
    }
}