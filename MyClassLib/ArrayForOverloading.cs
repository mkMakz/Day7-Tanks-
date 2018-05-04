using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class ArrayForOverloading
    {

        /*
         2.	Дан класс сожержащий внутри себя массив. 
         Реализовать перегрузку операторов < , > так, чтобы если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.
        */
        private Random random = new Random();
        public int[] mass;
       

        public ArrayForOverloading(int lenght, int sum)
        {
            mass = new int [lenght];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(1, 100);
            }

            
        }

    public static bool operator >(ArrayForOverloading arr, ArrayForOverloading arr1)
        {
            
            if (arr.mass.Sum() > arr1.mass.Sum())
                return true;
            else return false;

        }

        public static bool operator <(ArrayForOverloading arr, ArrayForOverloading arr1)
        {
            if (arr.mass.Sum() > arr1.mass.Sum())
                return true;
            else return false;
        }




    }
}
