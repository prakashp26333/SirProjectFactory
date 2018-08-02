using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public sealed class SingleTon
    {
        private static int counter = 0;
        private static Lazy<SingleTon> instance = new Lazy<SingleTon>( () => new SingleTon(), true) ;

        private SingleTon()
        {
            counter++;

            Console.WriteLine("Number of instances : {0}", counter);
        }

        public static SingleTon GetInstance
        {
            get
            {                
                return instance.Value;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine("Message Is {0}", message);
        }
    }  
}