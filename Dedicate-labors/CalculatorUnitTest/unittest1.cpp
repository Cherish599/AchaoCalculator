#include "stdafx.h"
#include "CppUnitTest.h"
#include"../Dedicate-labors/Calculator.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CalculatorUnitTest
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			// TODO: 在此输入测试代码
			Calculator* calc = new Calculator();
			std::string ret = calc->Solve("11+22");
			Assert::AreEqual(ret, (std::string)"11+22=33");
		}

	};
}