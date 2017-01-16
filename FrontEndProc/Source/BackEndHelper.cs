using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices; 

namespace MainApp
{
    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    // This class helper functions for back end structs. 

    public class BackEndHelper
    {
        public static void show(BackEndRecord1 aRecord)
        {
            Console.WriteLine("BackEndRecord1 Code1    {0}",aRecord.mCode1);
            Console.WriteLine("BackEndRecord1 Code2    {0}",aRecord.mCode2);
            Console.WriteLine("BackEndRecord1 Code3    {0}",aRecord.mCode3);
            Console.WriteLine("BackEndRecord1 Code4    {0}",aRecord.mCode4);
        }
    };
}