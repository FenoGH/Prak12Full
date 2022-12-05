using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionLib
{
    public class Task1
    {
        /// <summary>
        /// Нахождение площади круга
        /// </summary>
        /// <param name="r">радиус круга</param>
        /// <param name="s">площадь круга</param>
        /// <returns>Результатом функции является площадь</returns>
        public static double Sqare(double r, out double s)
        {
            double p = 3.14;
            s = Math.Pow(r, 2) * p;
            return s;
        }
        /// <summary>
        /// Нахождение площади кольца
        /// </summary>
        /// <param name="s1">Площадь круга 1</param>
        /// <param name="s2">Площадь круга 2</param>
        /// <param name="s3"> площадь круга 3</param>
        /// <returns>Результатом функции является площадь колца</returns>
        public static double Rinsqare(double s1, double s2, out double s3)
        {
            s3 = s1 - s2;
            return s3;
        }
    }
    public class Task2 
    { /// <summary>
    /// Определение века по введенному году
    /// </summary>
    /// <param name="year">Год</param>
    /// <param name="century">Век</param>
    /// <returns>Результатом функции является век в котором находится введенный год</returns>
     public static int Сentury(int year, out int century)
        {

            
            if (year > 99)
            {

                    century = (year / 100) + 1;
                    return century;
            }
            else
            {
                return century = 1;
            }
            
        }

    }
    
}
