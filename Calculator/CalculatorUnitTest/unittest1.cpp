#include "stdafx.h"
#include "CppUnitTest.h"
#include"../Calculator/Calculator.h"


using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CalculatorUnitTest
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			// TODO: �ڴ�������Դ���
			Calculator c;
			Assert::AreEqual(true,c.Is_int(3));
		}

	};
}