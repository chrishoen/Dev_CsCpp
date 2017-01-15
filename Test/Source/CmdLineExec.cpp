#include <math.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <random>

#include "prnPrint.h"
#include "CmdLineExec.h"

using namespace std;

// change201
//******************************************************************************
CmdLineExec::CmdLineExec()
{
   mX=101.123456;
   mT=0.1;
}
//******************************************************************************
void CmdLineExec::reset()
{
}
//******************************************************************************
void CmdLineExec::execute(Ris::CmdLineCmd* aCmd)
{
   if(aCmd->isCmd("RESET"  ))  reset();
   if(aCmd->isCmd("GO1"    ))  executeGo1(aCmd);
   if(aCmd->isCmd("GO2"    ))  executeGo2(aCmd);
   if(aCmd->isCmd("GO3"    ))  executeGo3(aCmd);
   if(aCmd->isCmd("GO4"    ))  executeGo4(aCmd);
   if(aCmd->isCmd("GO5"    ))  executeGo5(aCmd);

   if(aCmd->isCmd("X"      ))  mX=aCmd->argDouble(1);
   if(aCmd->isCmd("T"      ))  mT=aCmd->argDouble(1);
}

//******************************************************************************
//******************************************************************************
//******************************************************************************

//******************************************************************************
//******************************************************************************
//******************************************************************************

void CmdLineExec::executeGo1(Ris::CmdLineCmd* aCmd)
{
   aCmd->setArgDefault(1,4.0);
   double tX = aCmd->argDouble(1);

   int tN = int(round(tX));
   Prn::print(0, "***********************");
   Prn::print(0, "X   %10.6f",tX);
   Prn::print(0, "N   %10d",  tN);
}

//******************************************************************************
//******************************************************************************
//******************************************************************************

void CmdLineExec::executeGo2(Ris::CmdLineCmd* aCmd)
{
   aCmd->setArgDefault(1,101.123456);
   aCmd->setArgDefault(2,0.1);

   double tX = aCmd->argDouble(1);
   double tT = aCmd->argDouble(2);
   double tR = fmod(tX,tT);
   double tY = tX - tR;

   Prn::print(0, "***********************");
   Prn::print(0, "X   %10.6f",tX);
   Prn::print(0, "T   %10.6f",tT);
   Prn::print(0, "R   %10.6f",tR);
   Prn::print(0, "Y   %10.6f",tY);
   Prn::print(0, "");
   Prn::print(0, "D   %10.6f",tX-tY);
}

//******************************************************************************

void CmdLineExec::executeGo3(Ris::CmdLineCmd* aCmd)
{
   aCmd->setArgDefault(1,0.1);

   double tX = 101.123456;
   double tT = aCmd->argDouble(1);
   double tR = fmod(tX,tT);
   double tY = tX - tR;

   Prn::print(0, "***********************");
   Prn::print(0, "X   %10.6f",tX);
   Prn::print(0, "T   %10.6f",tT);
   Prn::print(0, "R   %10.6f",tR);
   Prn::print(0, "Y   %10.6f",tY);
   Prn::print(0, "");
   Prn::print(0, "D   %10.6f",tX-tY);
}

//******************************************************************************

void CmdLineExec::executeGo4(Ris::CmdLineCmd* aCmd)
{
   aCmd->setArgDefault(1,true);

   bool tX = aCmd->argBool(1);

   Prn::print(0, "X %d",tX);

   tX ^= true;

   Prn::print(0, "X %d",tX);
}

//******************************************************************************

void CmdLineExec::executeGo5(Ris::CmdLineCmd* aCmd)
{
   if (aCmd->numArg() > 0)
   {
      mX = aCmd->argDouble(1);
   }

   double tX = mX;
   double tT = mT;
   double tY = round(tX/tT)*tT;

   Prn::print(0, "***********************");
   Prn::print(0, "X   %10.6f",tX);
   Prn::print(0, "T   %10.6f",tT);
   Prn::print(0, "");
   Prn::print(0, "Y   %10.6f",tY);
   Prn::print(0, "D   %10.6f",tX-tY);
}

