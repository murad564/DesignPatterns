using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//SingletonPattern




//namespace Design_Patternsl;
//
//public sealed class President
//{
//
//    private President()
//    {
//     
//    }
//
//    private static President Instance;
//
//    public static President GetInstance()
//    {
//        if (Instance == null)
//        {
//            Instance = new President();
//        }
//        return Instance;
//    }
//
//    public void Someworks()
//    {
//
//    }
//}
//
//class Program
//{
//    static void Main()
//    {
//        President p1 = President.GetInstance();
//        President p2 = President.GetInstance();
//
//
//        if (p1 == p2)
//        {
//            Console.WriteLine("true");
//        }
//    }
//}