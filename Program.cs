using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Worker worker = new Worker();
            //worker.Work();
            //worker.Attendre();

            TasksHandler tHandler = new TasksHandler();
            tHandler.Attendre();

            Console.WriteLine("Je ne t'attend pas t une Task async : " + DateTime.Now);

            Console.ReadLine();
        }
    }
}
