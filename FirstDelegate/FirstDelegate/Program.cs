using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FirstDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate dlg = new MyDelegate();
            dlg.GetName("Shahane");
            //int age=MyDelegate.GetAge(24);
            //WriteLine(age);
            DelegateName dg = new DelegateName(dlg.GetName);
            dg("Garik");
            DelegateAge gd = new DelegateAge(MyDelegate.GetAge);
            int age=gd(24);
            WriteLine(age);
            
             
        }
    }
}
