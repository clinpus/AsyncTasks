using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTasks
{
    public class TasksHandler
    {


        public async void Attendre()
        {
            Worker worker = new Worker();
            Task resultTask = Task.Run(async () =>
            {
                worker.Attendre();
            });
        }


    }
}
