using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int playersCount = 2;
            //Console.WriteLine("how many player you need?");
            
            //List<Player> plist = new List<Player>();
            for (int i = 0; i < playersCount; i++)
            {
                var plyr = SetUpPlayer();
                //plist.Add(plyr);
                int plyr1Total = plyr.skls.Strenght + plyr.skls.Stamina + plyr.skls.Speed + plyr.skls.Momentum + plyr.skls.Service
                    + plyr.skls.Momentum + plyr.skls.RightHand + plyr.skls.LeftHand;


                Console.WriteLine("total sum of skills of " + plyr.name + " is " + plyr1Total);
                Console.ReadLine();

                plyr.wg.Wtrenght = (plyr.skls.Strenght / 10d); 
                plyr.wg.Wstamina = (plyr.skls.Stamina / 10d); 
                plyr.wg.Wspeed = (plyr.skls.Speed / 10d);
                plyr.wg.WrightH = (plyr.skls.RightHand / 20d);
                plyr.wg.WleftH = (plyr.skls.LeftHand / 20d);
                plyr.wg.Wmomentum = (plyr.skls.Momentum / 5d);
                plyr.wg.Wmentality = (plyr.skls.Mentality / 10d);
                plyr.wg.Wservice = (plyr.skls.Service / 5d);
                plyr.wg.Wpitch = (Convert.ToByte(PitchType.grass)/10);
                plyr.wg.Wcomp = (plyr.skls.Competition / 10d);

                plyr.wg.Wtotal = (plyr.wg.Wtrenght + plyr.wg.Wstamina + plyr.wg.Wspeed + plyr.wg.WrightH + plyr.wg.WleftH +
                    plyr.wg.Wmomentum + plyr.wg.Wmentality + plyr.wg.Wservice + plyr.wg.Wpitch + plyr.wg.Wcomp)*10d;


                Console.WriteLine(plyr.name + " has a total of " + plyr.wg.Wtotal);
                Console.ReadLine();

            }
           
        }

        private static Player SetUpPlayer()
        {            
            Skills skls = new Skills();
            Player plyr1 = new Player();
            Weight wg = new Weight();
            Console.WriteLine("Enter player name");
            plyr1.name = Console.ReadLine();

            Console.WriteLine("Enter player Strenght:");
            plyr1.skls = skls;
            var t = Console.ReadLine();
            plyr1.skls.Strenght = Convert.ToInt32(t);//set
            var y = plyr1.skls.Strenght;//get

            Console.WriteLine("Enter player Stamina");
            var s = Console.ReadLine();
            plyr1.skls.Stamina = Convert.ToInt32(s);

            Console.WriteLine("Enter player Speed");
            var spd = Console.ReadLine();
            plyr1.skls.Speed = Convert.ToInt32(spd);

            Console.WriteLine("Enter player Momentum");
            var mom = Console.ReadLine();
            plyr1.skls.Momentum = Convert.ToInt32(mom);

            Console.WriteLine("Enter player Service");
            var ser = Console.ReadLine();
            plyr1.skls.Service = Convert.ToInt32(ser);

            Console.WriteLine("Enter player Mentality");
            var mnt = Console.ReadLine();
            plyr1.skls.Mentality = Convert.ToInt32(mnt);

            Console.WriteLine("Enter player Right hand");
            var rhg = Console.ReadLine();
            plyr1.skls.RightHand = Convert.ToInt32(rhg);
            int t2 = Convert.ToInt32(rhg);


            Console.WriteLine("Left hand");
            var lft = Console.ReadLine();
            plyr1.skls.LeftHand = Convert.ToInt32(lft);

            Console.WriteLine("Competition value");
            var comp = Console.ReadLine();
            plyr1.skls.Competition = Convert.ToInt32(comp);


            Console.WriteLine("Enter the pitch");
            plyr1.skls.Pitch = (PitchType)Convert.ToByte((Console.ReadLine()));
            plyr1.wg = wg;
            return plyr1;
        }
    }
}
