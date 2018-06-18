using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();            

            UpLoadVideo activity = new UpLoadVideo();

            SayHi sayHi = new SayHi();

            workflowEngine.Run(sayHi);

            //workflowEngine.Run(activity);

            Console.ReadLine();
        }
    }
}
