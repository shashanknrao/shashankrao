using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Ninject;

namespace NinjectNet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var kernal = new Ninject.StandardKernel())
            {
                kernal.Bind<ILogger>().To<ConsoleLogger>();
                var service = kernal.Get<SalutationService>();
                var mailService = new MailService();
                service.SayHello();
            }
        }
    }
}
