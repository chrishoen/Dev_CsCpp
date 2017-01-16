#include <stdio.h>
#include <string.h>
#include <windows.h>
#include <atomic>
#include "BackEndData.h"


//******************************************************************************
//******************************************************************************
//******************************************************************************
// Initialize

void initialize(BackEndRecord1* aRecord)
{
   aRecord->mCode1=101;
   aRecord->mCode2=102;
   aRecord->mCode3=103;
   aRecord->mCode4=104;
}
