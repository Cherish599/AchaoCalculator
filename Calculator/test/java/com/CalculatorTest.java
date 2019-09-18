package com;

import com.Calculator;
import org.junit.Assert;
import org.junit.Test;
import org.junit.Before;
import org.junit.After;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 * Calculator Tester.
 *
 * @author <Authors name>
 * @since <pre>09/17/2019</pre>
 * @version 1.0
 */
public class CalculatorTest {
    Calculator calculator=new Calculator();
    @Before
    public void before() throws Exception {
    }

    @After
    public void after() throws Exception {
    }

    /**
     * Method: createFormula()
     */
    @Test
    public void testCreateFormula() throws Exception {
//TODO: Test goes here...

    }

    /**
     * Method: solve(List formula)
     */
    @Test
    public void testSolve() throws Exception {
//TODO: Test goes here...
        List<Object> a=new ArrayList<>(Arrays.asList(26,"+",97,"/",90,"+",54));
        Assert.assertEquals(calculator.solve(a),81);
    }

    /**
     * Method: main(String[] args)
     */
    @Test
    public void testMain() throws Exception {
//TODO: Test goes here...
    }
}