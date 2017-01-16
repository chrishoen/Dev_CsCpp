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
    // Record1. This is used by the back end dll.

    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public struct BackEndRecord1
    {
        public int mCode1;
        public int mCode2;
        public int mCode3;
        public int mCode4;
    } 

    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    // This class provides bindings to functions that are exported by the back 
    // end dll. A call to one of these is a call to the function in the dll.

    public class BackEnd
    {
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        public const string cDLLName = @"..\..\..\x64\Release\BackEndDLL.dll";

        // Increment a parameter.
        [DllImport(cDLLName)]
        public static extern int be_function1(int aN);

        // Call a callback.
        public delegate void Callback2();
        [DllImport(cDLLName)]
        public static extern void be_function2(Callback2 callback);
            
        // Initialize a struct.
        [DllImport(cDLLName)]
        public static extern void be_function3(ref BackEndRecord1 aRecord);
    };

}