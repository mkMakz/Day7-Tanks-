using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.Models;

namespace MyClassLib
{
    public class War
    {
        List<Tanks> team1;
        List<Tanks> team2;
        public War()
        {
            team1 = new List<Tanks>();
            team2 = new List<Tanks>();
        }

       public void FillLists(Tanks tank)
        {
            if (tank.TankType.Equals("T34"))
                team1.Add(tank);
            else
                team2.Add(tank);


        }

        public void ListInfo()
        {
            foreach (Tanks item in team1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            foreach (Tanks item in team2)
            {
                Console.WriteLine(item);
            }
        
        }

    }
}
