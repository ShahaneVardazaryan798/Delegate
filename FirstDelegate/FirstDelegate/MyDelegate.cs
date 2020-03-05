using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDelegate
{
    public delegate void DelegateName(string name);
    public delegate int DelegateAge(int age);
    class MyDelegate
    {
        
        public void GetName(string name)
        {
            Console.WriteLine(name);
        }
        public static int GetAge(int age)
        {
            return age;
        }
    
    }
}
