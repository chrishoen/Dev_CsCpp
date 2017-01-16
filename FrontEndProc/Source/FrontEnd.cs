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
    // This is a front end example class. It calls functions that reside in
    // the back end dll.

    public class FrontEnd
    {
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Members


        //**********************************************************************
        // Constructor

        public FrontEnd()
        {
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Call the back end function.

        public void doRun1()
        {
            Console.WriteLine("be_function1 {0}", BackEnd.be_function1(101));
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Call the back end function.

        public void doCallback2()
        {
            Console.WriteLine("doCallback2");
        }

        public void doRun2()
        {
            BackEnd.be_function2(doCallback2);
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Call the back end function.

        public void doRun3()
        {
            BackEndRecord1 tRecord = new BackEndRecord1();
            BackEnd.be_function3(ref tRecord);
            BackEndHelper.show(tRecord);
        }

    };

}