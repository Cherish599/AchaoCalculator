package com.zzj.Calculator;

class CalculatorMachineTest {

    /**
     * 需要测试的类
     */
    private CalculatorMachine calculatorMachine = new CalculatorMachine();

    /**
     * 测试生成的方法
     */
    @org.junit.jupiter.api.Test
    void getAll() {
        calculatorMachine.getAll(10);
    }

}