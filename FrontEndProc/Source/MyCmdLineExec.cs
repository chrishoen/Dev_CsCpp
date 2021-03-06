﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ris;

namespace MainApp
{
    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    class MyCmdLineExec : BaseCmdLineExec
    {
        //**********************************************************************

        public MyCmdLineExec()
        {
            reset();
        }

        public override void reset()
        {
        }

        //**********************************************************************

        public override void execute(CmdLineCmd aCmd)
        {
            if (aCmd.isCmd("Run1"))   OnRun1(aCmd);
            if (aCmd.isCmd("Run2"))   OnRun2(aCmd);
            if (aCmd.isCmd("Run3"))   OnRun3(aCmd);

            if (aCmd.isCmd("GO1")) OnGo1(aCmd);
            if (aCmd.isCmd("GO2")) OnGo2(aCmd);
            if (aCmd.isCmd("GO3")) OnGo3(aCmd);
            if (aCmd.isCmd("GO4")) OnGo4(aCmd);
            if (aCmd.isCmd("GO5")) OnGo5(aCmd);
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public void OnRun1(CmdLineCmd aCmd)
        {
            FrontEnd tFrontEnd = new FrontEnd();
            tFrontEnd.doRun1();
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public void OnRun2(CmdLineCmd aCmd)
        {
            FrontEnd tFrontEnd = new FrontEnd();
            tFrontEnd.doRun2();
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public void OnRun3(CmdLineCmd aCmd)
        {
            FrontEnd tFrontEnd = new FrontEnd();
            tFrontEnd.doRun3();
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public void OnGo1(CmdLineCmd aCmd)
        {
            Console.WriteLine("Hello World");
        }

        //**********************************************************************

        public void OnGo2(CmdLineCmd aCmd)
        {
            aCmd.setArgDefault(1, "aaaaaaa");
            aCmd.setArgDefault(2, 111);
            aCmd.setArgDefault(3, 22.22);

            Console.WriteLine("{0} {1} {2}", aCmd.argString(1), aCmd.argInt(2), aCmd.argDouble(3));
        }

        //**********************************************************************

        public void OnGo3(CmdLineCmd aCmd)
        {
            aCmd.setArgDefault(1, "aaaaaaa");

            Console.WriteLine("GO3{0,-10}GO3", aCmd.argString(1));
        }

        //**********************************************************************

        public void OnGo4(CmdLineCmd aCmd)
        {
            aCmd.setArgDefault(1, 101);

            UInt16 tN = aCmd.argUInt16(1);

            Console.WriteLine("{0}", tN);
        }


        //**********************************************************************

        public void OnGo5(CmdLineCmd aCmd)
        {
            aCmd.setArgDefault(1, 0x20);

            UInt64 tN = aCmd.argUInt64(1);

            Console.WriteLine("0x{0,16:X}", tN);
            
        }


    }
}
