using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClass_TwoInterfacesIntoAnotherClass
{
    internal class Nokia1100 : INokia1
    {
        public void calling()
        {
            Console.WriteLine("CALLING FROM NOKIA1100 MOBILE");
        }

        public void endcall()
        {
            Console.WriteLine("call ended by 1100");
        }

        public void receiving()
        {
            Console.WriteLine("call recieved by 1100");
        }

        public void sendmessage()
        {
            Console.WriteLine("message is sending from nokia1100");
        }
    }
}
