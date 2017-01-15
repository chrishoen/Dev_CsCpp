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
    // 

    public class FrontEnd
    {
        //----------------------------------------------------------------------
        // Members


        //----------------------------------------------------------------------
        // Constructor

        public FrontEnd()
        {
        }

        //----------------------------------------------------------------------

        public void doRun1()
        {
            Console.WriteLine("doRun1");
        }

        //[DllImport("@..\..\..\x64\Release\BackEnd.dll")]
        [DllImport(@"C:\Prime\DevelopComm\Dev_CsCpp\x64\Release\BackEndDLL.dll")]
        public static extern int be_function1(int aN);
            
    };

}