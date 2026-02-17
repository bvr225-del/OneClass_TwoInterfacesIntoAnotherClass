using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClass_TwoInterfacesIntoAnotherClass
{
    internal class Program
    {
        static void Main(string[] args)
        {//We cannot create object for interface but we can create a reference variable for interface.
         //Syntax:Interfacename refrenceVariablename=new Childclassname()
         //FirstWay of accessing Nokia1100 vlass methods 
            INokia1 objinokia1 = new Nokia1100();
            objinokia1.calling();
            objinokia1.receiving();
            objinokia1.endcall();
            objinokia1.sendmessage();
            objinokia1 = new NokiaAsha();
            objinokia1.calling();
            objinokia1.receiving();
            objinokia1.endcall();
            objinokia1.sendmessage();
            objinokia1 = null;
            INokia2 objinokia2 = new NokiaAsha();
            objinokia2.Bluetooth();
            objinokia2.Wifi();
            objinokia2 = null;
            NokiaAsha objinokiaasha = new NokiaAsha();
            objinokiaasha.Wifi();
            objinokiaasha.print();

            //==================(OR)//SECOND WAY CALLING METHODS BY USING CREATE DIRECT OBJECT OF THE CHILD CLASS====================
            //Create the object for child classes and we can access those methods.
            Nokia1100 nokia1100Obj = new Nokia1100();
            nokia1100Obj.calling();
            nokia1100Obj.endcall();
            nokia1100Obj.sendmessage();
            nokia1100Obj.receiving();


            NokiaAsha nokiaAshaObj = new NokiaAsha();

            nokiaAshaObj.calling();
            nokiaAshaObj.sendmessage();
            nokiaAshaObj.receiving();
            nokiaAshaObj.endcall();
            nokiaAshaObj.Wifi();
            nokiaAshaObj.Bluetooth();
            nokiaAshaObj.print();

            //=====================*******
            //we can inherit hybrid inheritance into another child clas also...
            //inheritance always inherit the members from base to derived class.
            Sample samObj = new Sample();
            samObj.Bluetooth();
            samObj.endcall();
            samObj.calling();
            samObj.receiving();
            samObj.Bluetooth();
            samObj.print();





            Console.ReadLine();
        }
    }
}
/*
 CALLING FROM NOKIA1100 MOBILE
call recieved by 1100
call ended by 1100
message is sending from nokia1100
Calling from NokiaAsha MOBILE
call recieved by NokiaAsha
call ended by NokiaAsha
message is sending from nokiaAsha
I am using blueetooth
call  by Wifi
call  by Wifi
print is calling
CALLING FROM NOKIA1100 MOBILE
call ended by 1100
message is sending from nokia1100
call recieved by 1100
Calling from NokiaAsha MOBILE
message is sending from nokiaAsha
call recieved by NokiaAsha
call ended by NokiaAsha
call  by Wifi
I am using blueetooth
print is calling
I am using blueetooth
call ended by NokiaAsha
Calling from NokiaAsha MOBILE
call recieved by NokiaAsha
I am using blueetooth
print is calling

*/