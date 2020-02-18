using System;
using Unity;
using Microsoft.Practices.Unity.Configuration;
using Interfaces;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer().LoadConfiguration();

            var type = container.Resolve<InterfaceN>();

            Console.WriteLine(type.GetString());
        }
    }
}
