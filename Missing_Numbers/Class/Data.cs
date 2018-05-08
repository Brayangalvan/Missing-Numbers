namespace Missing_Numbers.Class
{
    using System;

    /// <summary>
    /// Class for tha manipulation of data
    /// </summary>
    public static class Data
    {
        /// <summary>
        /// Get parameters by console
        /// </summary>
        public static void GetParamts()
        {
            Validation validation = new Validation();
            Procedure procedure = new Procedure();

            int n = Convert.ToInt32(Console.ReadLine());
            validation.ValidatonSizeVector(n);

            int[] arr = ConvertStringToVectorInt(Console.ReadLine());
            validation.ValidatonSizeVectorAndData(n, arr.Length);

            int m = Convert.ToInt32(Console.ReadLine());
            validation.ValidatonSizeVector(m);

            validation.ValidatonVectors(n, m);

            int[] brr = ConvertStringToVectorInt(Console.ReadLine());
            validation.ValidatonSizeVectorAndData(m, brr.Length);
            validation.ValidatonDifferenceBetweenMaximumAndMinimumData(brr);

            int[] result = procedure.MissingNumbers(arr, brr);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        /// <summary>
        /// Convert a strings in vector of int
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static int[] ConvertStringToVectorInt(string data)
        {
            return Array.ConvertAll(data.Split(' '), Int32.Parse);
        }
    }
}