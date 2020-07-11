using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static ArrayList bees;

        [STAThread]
        static void Main()
        {
            bees = new ArrayList();
            initializeList();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void initializeList()
        {
            for (int i = 0; i <= 10; i++)
            {
                Worker worker = new Worker();
                bees.Add(worker);
            }
            for (int i = 0; i <= 10; i++)
            {
                Queen queen = new Queen();
                bees.Add(queen);
            }
            for (int i = 0; i <= 10; i++)
            {
                Drone drone = new Drone();
                bees.Add(drone);
            }
        }

        public static ArrayList getBees()
        {
            return bees;
        }
        public static void damageBees()
        {
            Random rnd = new Random();
            foreach (Bees bee in bees)
            {
                bee.damage(rnd.Next(0, 80));
            }
        }
    }
}
