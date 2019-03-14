using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        private string name;
        private int levelOfAmmunition;
        private int levelOfArmor;
        private int levelOfManeuverability;
        public string Name { get { return name; } set { name = value; } }
        public int LevelOfAmmunition { get { return levelOfAmmunition; } set { levelOfAmmunition = value; } }
        public int LevelOfArmor { get { return levelOfArmor; } set { levelOfArmor = value; } }
        public int LevelOfManeuverability { get { return levelOfManeuverability; } set { levelOfManeuverability = value; } }
        static Random random = new Random();
        public Tank(string _name)
        {           
            name = _name;
            levelOfAmmunition = random.Next(0, 100);            
            levelOfArmor = random.Next(0, 100);
            levelOfManeuverability = random.Next(0, 100);
        }
        public void TankInfo()
        {
            Console.WriteLine(
                $"Параметры танка {name}\n" +
                $"Уровень боекомплекта: {levelOfAmmunition}\n" +
                $"Уровень брони: {levelOfArmor}\n" +
                $"Уровень маневренности: {levelOfManeuverability}\n"
                );
        }
        public static Tank operator *(Tank firstTank, Tank secondTank)
        {
            int firstWin = 0;
            int secondWin = 0;
            Console.WriteLine($"Сражение танка {firstTank.name} и {secondTank.name}");
            if (firstTank.levelOfAmmunition > secondTank.levelOfAmmunition)
            {
                firstWin += 1;
            }
            else
            {
                secondWin += 1;
            }
            if (firstTank.levelOfArmor > secondTank.levelOfArmor)
            {
                firstWin += 1;
            }
            else
            {
                secondWin += 1;
            }
            if (firstTank.levelOfManeuverability > secondTank.levelOfManeuverability)
            {
                firstWin += 1;
            }
            else
            {
                secondWin += 1;
            }
            if (firstWin > secondWin)
            {
                Console.WriteLine($"Побеждает танк {firstTank.name}\n");
                return firstTank;
            }
            else
            {
                Console.WriteLine($"Побеждает танк {secondTank.name}\n");
                return secondTank;
            }
        }
    }
}
