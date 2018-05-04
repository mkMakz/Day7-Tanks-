using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.Models;
using MyClassLib;


namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanks tank1 = new Tanks(TankType.T34);
            Tanks tank2 = new Tanks(TankType.Panter);
            Tanks tank3 = new Tanks(TankType.T34);
            Tanks tank4 = new Tanks(TankType.Panter);
            Tanks tank5 = new Tanks(TankType.T34);
            Tanks tank6 = new Tanks(TankType.Panter);
            Tanks tank7 = new Tanks(TankType.T34);
            Tanks tank8 = new Tanks(TankType.Panter);
            Tanks tank9 = new Tanks(TankType.T34);
            Tanks tank10 = new Tanks(TankType.Panter);

            var res = tank1 * tank2;
            Console.WriteLine(res);

            Console.WriteLine("\n");

            res = tank3 * tank10;
            Console.WriteLine(res);

            res = tank3 * tank1;
            Console.WriteLine(res);

            Console.WriteLine("\n");

            bool compare;
            compare = tank3 == tank1;
            Console.WriteLine(compare);

            Console.WriteLine("\n");

            Console.WriteLine(tank10.Equals(tank3));

            Console.WriteLine("\n");

            ArrayForOverloading arr = new ArrayForOverloading(20, 500);
            ArrayForOverloading arr1 = new ArrayForOverloading(20, 650);

            bool result = arr > arr1;

            Console.WriteLine(result);


        }
    }
}
