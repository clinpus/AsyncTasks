using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTasks
{
    public class Worker
    {

        public async Task Attendre()
        {
            Console.WriteLine("Debut Attendre : " + DateTime.Now);
            Thread.Sleep(4000);
            Console.WriteLine("Fin Attendre : " + DateTime.Now);
        }

        public async Task Work()
        {
            /*
            Random random = new Random();
            afficherMessage(random.Next(1000, 5000));          
            afficherMessagePartager(random.Next(1000, 5000), "");
            */
            List<Task> lstTask = new List<Task>();
            TasksProvider tProv = new TasksProvider(lstTask);
            tProv.ProvideTasks(5);
            
        }

        /*
        public async Task afficherMessage(int delay)
        {
            Console.WriteLine("Debut afficherMessage : " + DateTime.Now);
            for (int i = 0; i < 3; i++)
            {
                await Task.Delay(delay);
                Console.WriteLine("En cours de afficherMessage : " + DateTime.Now);
            }
            Console.WriteLine("Fin afficherMessage :  " + DateTime.Now);
        }

        public async Task afficherMessagePartager(int delay, string Message)
        {
            Console.WriteLine("Debut afficherMessagePartager  : " + DateTime.Now);
            Console.WriteLine("Mon Message Partage : '" + Message + "' at :  " + DateTime.Now);
            for (int i = 0; i < 3; i++)
            {
                await Task.Delay(delay);
                Console.WriteLine("En cours de Mon Message Partage : '" + Message + "' at :  " + DateTime.Now);
            }
            Console.WriteLine("Fin afficherMessagePartager :  " + DateTime.Now);
        }
        */
    }
}
