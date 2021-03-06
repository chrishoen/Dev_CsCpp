#include <stdio.h>
#include <string.h>
#include <windows.h>
#include <atomic>
#include "BackEndDLL.h"


//******************************************************************************
//******************************************************************************
//******************************************************************************
// Increment a parameter.

int DllExport be_function1(int aN)
{
   return aN + 1;
}

//******************************************************************************
//******************************************************************************
//******************************************************************************
// Call a callback.

void DllExport be_function2(Callback2 aCallback)
{
   // Guard.
   if (aCallback==0) return;

   // Call the callback.
   aCallback();
}

//******************************************************************************
//******************************************************************************
//******************************************************************************
// Initialize a struct.

void DllExport be_function3(BackEndRecord1* aRecord)
{
   initialize(aRecord);
}
