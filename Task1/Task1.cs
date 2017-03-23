using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task1
    {
        #region EuclidMethod
        /// <summary>
        /// Method that calculate a GCD by Euclid algorythm
        /// </summary>
        /// <param name="a">the first int number</param>
        /// <param name="b">the second int number</param>
        /// <returns>return a GCD</returns>
        private static int EuclidAlgo(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {

                return a;
            }
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }
        /// <summary>
        /// Method that calculate a GCD by Euclid algorythm and measure the time 
        /// </summary>
        /// <param name="a">the first int number</param>
        /// <param name="b">the second int number</param>
        /// <returns>return a GCD</returns>
        public static int EuclidMethod(int a, int b)
        {
            var timer = new Stopwatch();
            timer.Start();
            int res = EuclidAlgo(a, b);
            timer.Stop();
            double time = timer.ElapsedMilliseconds;
            return res;
        }

        /// <summary>
        /// Method that calculate a GCD by Euclid algorythm and measure the time 
        /// </summary>
        /// <param name="arr">takes many integer parameters</param>
        /// <returns> </returns>
        public static int EuclidMethod(params int[] arr)
        {
            var timer = new Stopwatch();
            double time;
            timer.Start();

            if (arr == null) throw new ArgumentNullException(nameof(arr));

            int res = 0;
            foreach (var item in arr)
            {
                res = EuclidAlgo(res, item);
            }
            timer.Stop();
            time = timer.ElapsedMilliseconds;
            return res;
        }
        #endregion
        #region SteinMethod
        /// <summary>
        /// Method that calculate a GCD by Euclid algorythm and measure the time 
        /// </summary>
        /// <param name="a">the first int</param>
        /// <param name="b">the second int parameter</param>
        /// <returns>returns a GCD calculated by the Stein method</returns>
        private static int SteinAlgo(int a, int b)
        {
            if (a == 0) return Math.Abs(b);
            if (b == 0) return Math.Abs(a);
            if (a == b) return Math.Abs(a);
            if (a == 1) return a;
            if (b == 1) return b;
            if (a % 2 == 0 && b % 2 == 0) return 2 * SteinMethod(a / 2, b / 2);
            if (a % 2 == 0 && b % 2 != 0) return SteinMethod(a / 2, b);
            if (a % 2 != 0 && b % 2 == 0) return SteinMethod(a, b / 2);
            return SteinAlgo(b, Math.Abs(a - b));
        }

        /// <summary>
        /// Method that calculate a GCD by Euclid algorythm and measure the time 
        /// </summary>
        /// <param name="a">the first int</param>
        /// <param name="b">the second int parameter</param>
        /// <returns>returns a GCD calculated by the Stein method</returns>
        public static int SteinMethod(int a, int b, out double time)
        {
            var timer = new Stopwatch();
            timer.Start();

            int res = SteinAlgo(a, b);

            timer.Stop();
            time = timer.ElapsedMilliseconds;
            return res;
        }

        /// <summary>
        /// Method that calculate a GCD by Euclid algorythm and measure the time for many arguments
        /// </summary>
        /// <param name="arr">takes many parameters</param>
        /// <returns>returns GCD by the Stein Method</returns>
        public static int SteinMethod(params int[] arr)
        {
            var timer = new Stopwatch();
            timer.Start();
            double time;

            if (arr == null) throw new ArgumentNullException(nameof(arr));

            int res = 0;
            foreach (var item in arr)
            {
                res = SteinAlgo(res, item);
            }
            timer.Stop();
            time = timer.ElapsedMilliseconds;

            return res;
        }
        #endregion
    }
}