#include "stdafx.h"
#include "CppUnitTest.h"
#include "../Calculator/Calculator.h"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			// TODO: 在此输入测试代码
			Calculator test;
			Assert::AreEqual(59, test.Solve("12+25/5+12*3+12/2="));
			Assert::AreEqual(2034, test.Solve("61*34-81+41="));
			Assert::AreEqual(758, test.Solve("72*11-18-16="));
			Assert::AreEqual(1540, test.Solve("44*35="));
			Assert::AreEqual(2165, test.Solve("95+68*30+30="));
		}

	};
}