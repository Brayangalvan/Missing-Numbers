namespace Missing_Numbers.Class
{
    using System.Linq;

    /// <summary>
    /// Procedure of project
    /// </summary>
    public class Procedure
    {
        /// <summary>
        /// Get Missing  Numbers
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="brr"></param>
        /// <returns></returns>
        public int[] MissingNumbers(int[] arr, int[] brr)
        {
            //Compare vectors and if you find it, change it to 0
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

            //Select the values different of 0 and no repeat
            int[] result = brr.Where(item => item != 0).Distinct().ToArray();

            //the order ascending
            return result.OrderBy(x => x).ToArray();
        }
    }
}