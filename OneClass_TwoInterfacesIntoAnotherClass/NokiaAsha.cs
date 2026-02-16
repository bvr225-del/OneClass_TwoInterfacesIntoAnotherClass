using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClass_TwoInterfacesIntoAnotherClass
{
    // internal class NokiaAsha : INokia1, INokia2, MyClass
    //NOTE:MyClass ALWAYS WRITTEN BEFORE INTERFACES IN INHERITANCE PROCESS.OTHERWISE IT WILL THROW ERROR.
    internal class NokiaAsha : MyClass, INokia1, INokia2
    {
        public void Bluetooth()
        {
            Console.WriteLine("I am using blueetooth");
        }

        public void calling()
        {
            Console.WriteLine("Calling from NokiaAsha MOBILE");
        }

        public void endcall()
        {
            Console.WriteLine("call ended by NokiaAsha");
        }

        public void receiving()
        {
            Console.WriteLine("call recieved by NokiaAsha");
        }

        public void sendmessage()
        {
            Console.WriteLine("message is sending from nokiaAsha");
        }

        public void Wifi()
        {
            Console.WriteLine("call  by Wifi");
        }
    }
}
