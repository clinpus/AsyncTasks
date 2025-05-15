using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTasks
{
    public class TasksProvider
    {

        public List<Task> lstTask;
        public TasksProvider(List<Task> _lstTask)
        {
            lstTask = _lstTask;
        }

        public async void ProvideTasks(int tasksNumber)
        {

            Random random = new Random();
            for (int i = 0; i < tasksNumber; i++)
            {
                int tskPrio = random.Next(1, 10);
                int delay = random.Next(4000, 5000);
                //afficherMessage(delay);
                lstTask.Add(afficherMessage(delay));
                Thread.Sleep(2000);
            }

        }


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

    }
}
