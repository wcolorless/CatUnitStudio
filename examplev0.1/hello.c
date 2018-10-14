#include <stdio.h>
#include <assert.h>
#include "CatUnit.h"



int Add(int a, int b)
{
   return a + b;
}


int Min(int a, int b)
{
	return a - b;
}

int Mul(int a, int b)
{
	return a * b;
}

int Func(int a, int b)
{
  int c =  Add(a, b);
  return Mul(c, 2);
}

void Test_Add()
{
	TEST_ASSERT(4 == Add(2, 2), "Test_Add");
}

void Test_Min()
{
	TEST_ASSERT(0 == Min(2, 2), "Test_Min");
}


void Test_Mul()
{
    TEST_ASSERT(4 == Mul(2, 2), "Test_Mul");
}


void Test_Func()
{
	TEST_ASSERT_0NE_MESSAGE(7 == Func(2,2), "Function 'Func' has not passed test", "Test_Func");
}
	


