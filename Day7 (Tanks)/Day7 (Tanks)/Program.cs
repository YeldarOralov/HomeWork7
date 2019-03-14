using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tankT34One = new Tank("Авалон");
            Tank tankT34Two = new Tank("Мечта");
            Tank tankT34Three = new Tank("Разрушитель");
            Tank tankT34Four = new Tank("Деструктор");
            Tank tankT34Five = new Tank("Радуга");
            Tank tankPanteraOne = new Tank("ПиуПиу");
            Tank tankPanteraTwo = new Tank("Лидер");
            Tank tankPanteraThree = new Tank("Ласточка");
            Tank tankPanteraFour = new Tank("Антанта");
            Tank tankPanteraFive = new Tank("Медведь");

            tankT34One.TankInfo();            
            tankPanteraOne.TankInfo();
            var fight = tankT34One * tankPanteraOne;

            tankT34Two.TankInfo();
            tankPanteraTwo.TankInfo();
            fight = tankT34Two * tankPanteraTwo;

            tankT34Three.TankInfo();
            tankPanteraThree.TankInfo();
            fight = tankT34Three * tankPanteraThree;

            tankT34Four.TankInfo();
            tankPanteraFour.TankInfo();
            fight = tankT34Four * tankPanteraFour;

            tankT34Five.TankInfo();
            tankPanteraFive.TankInfo();
            fight = tankT34Five * tankPanteraFive;

            
            Console.Read();
        }
    }
}
