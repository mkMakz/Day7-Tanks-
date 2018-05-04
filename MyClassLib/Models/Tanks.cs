using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;


namespace MyClassLib.Models
{
    public enum TankType { T34, Panter };

    public class Tanks
    {
        /// <summary>
        /// Боекомплект
        /// </summary>
        private int Ammunition { get; set; }
        /// <summary>
        /// Броня
        /// </summary>
        private int Armor { get; set; }
        /// <summary>
        /// Манёвренность
        /// </summary>
        private int Maneuverablility { get; set; }

        public TankType TankType { get; set; }

        public Tanks() { }
        public Tanks(TankType Tank)
        {
            Random rand = new Random();
            Ammunition = rand.Next(0, 100);
            Armor = rand.Next(0, 100);
            Maneuverablility = rand.Next(0, 100);
            TankType = Tank;
            War war = new War();
            war.FillLists(this);

        }

        public static Tanks operator *(Tanks t1, Tanks t2)
        {
            Tanks winner = new Tanks();
            if (t1.Ammunition > t2.Ammunition &&
                t1.Armor > t2.Armor)
                winner = t1;
            else if (t1.Ammunition > t2.Ammunition &&
                t1.Maneuverablility > t2.Maneuverablility)
                winner = t1;
            else if (t1.Armor > t2.Armor &&
                t1.Maneuverablility > t2.Maneuverablility)
                winner = t1;
            else winner = t2;
            return winner;
        }

        public override string ToString()
        {
            string info = string.Format("Type: {0} " + " \n Боекомплект {1}" + "\n Броня {2}" + "\n Манёвренность {3}",
                this.TankType.ToString(), this.Ammunition, this.Armor, this.Maneuverablility);
            return info;
        }

        // перегрузить операторы ==, != и Equals

        public static bool operator ==(Tanks tank, Tanks tank1)
        {
            if (tank.Ammunition == tank1.Ammunition && tank.Armor == tank1.Armor && tank.Maneuverablility == tank1.Maneuverablility)
                return true;
            else return false;
        }

        public static bool operator !=(Tanks tank, Tanks tank1)
        {
            // return !(tank == tank1);
            if (tank.Ammunition != tank1.Ammunition || tank.Armor != tank1.Armor || tank.Maneuverablility != tank1.Maneuverablility)
                return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            else if (obj == null || this.GetType() != obj.GetType())
                return false;
            Tanks tanks = (Tanks)obj;

            return this.TankType.Equals(tanks.TankType);
        }

        //Перегрузить операторы <, >

       
    }
}
