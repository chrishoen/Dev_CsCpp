#include <stdio.h>
#include <string.h>
#include <windows.h>
#include <atomic>
#include "BackEndDLL.h"


//******************************************************************************
//******************************************************************************
//******************************************************************************
// Initialize

int DllExport be_function1(int aN)
{
   return aN + 1;
}

void DllExport be_function2(Callback2 aCallback)
{
   // Guard.
   if (aCallback==0) return;

   // Call the callback.
   aCallback();
}
