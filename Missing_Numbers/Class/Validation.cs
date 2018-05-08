namespace Missing_Numbers.Class
{
    using System;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// Class for business rules
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Validation of size vector
        /// </summary>
        /// <param name="size"></param>
        public void ValidatonSizeVector(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("El tamaño del vector debe ser mayor a 0.");
                Thread.Sleep(2000);
                Console.Clear();
                Data.GetParamts();
            }
        }

        /// <summary>
        /// Validate the size data be equals the size specified
        /// </summary>
        /// <param name="size"></param>
        /// <param name="data"></param>
        public void ValidatonSizeVectorAndData(int size, int data)
        {
            if (size == data)
            {
                Console.WriteLine("Los datos del vector sobre pasan la capacidad establecida.");
                Thread.Sleep(2000);
                Console.Clear();
                Data.GetParamts();
            }
        }

        /// <summary>
        /// Validate that the vector 1 is lesser vector2
        /// </summary>
        /// <param name="size"></param>
        /// <param name="data"></param>
        public void ValidatonVectors(int vector1, int vector2)
        {
            if (vector1 > vector2)
            {
                Console.WriteLine("El vector 1 es mayor al vector2.");
                Thread.Sleep(2000);
                Console.Clear();
                Data.GetParamts();
            }
        }

        /// <summary>
        /// Validate that the difference between maximum and minimum
        /// of second vector is less than 100
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        public void ValidatonDifferenceBetweenMaximumAndMinimumData(int[] vector1)
        {
            if (vector1.Max() - vector1.Min() < 101)
            {
                Console.WriteLine("El vector 1 es menor al vector2.");
                Thread.Sleep(2000);
                Console.Clear();
                Data.GetParamts();
            }
        }
    }
}