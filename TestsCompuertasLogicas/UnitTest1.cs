namespace TestsCompuertasLogicas;

using CompuertasLogicas;

public class Tests
{
    [Test]
    public void TestLogicValueOutput()
    {
        IInput a = new LogicValue(false);
        
        Assert.That(a.OutputValue, Is.EqualTo(false));
    }
    
    [Test]
    public void TestAndGateAddsInput()
    {
        IInput a = new LogicValue(true);

        IGate and = new AndGate();
        and.AddInput(a);
        
        Assert.That(and.Inputs, Does.Contain(a));
    }
    
    [Test]
    public void TestAndGateOutputValueShouldBeTrue()
    {
        IInput a = new LogicValue(true);
        IInput b = new LogicValue(true);

        IGate and = new AndGate();
        and.AddInput(a);
        and.AddInput(b);
        
        Assert.That(and.OutputValue, Is.EqualTo(true));
    }
    
    [Test]
    public void TestAndGateOutputValueShouldBeFalse()
    {
        IInput a = new LogicValue(true);
        IInput b = new LogicValue(false);

        IGate and = new AndGate();
        and.AddInput(a);
        and.AddInput(b);
        
        Assert.That(and.OutputValue, Is.EqualTo(false));
    }
    
    [Test]
    public void TestOrGateAddsInput()
    {
        IInput a = new LogicValue(true);

        IGate or = new OrGate();
        or.AddInput(a);
        
        Assert.That(or.Inputs, Does.Contain(a));
    }
    
    [Test]
    public void TestOrGateOutputValueShouldBeTrue()
    {
        IInput a = new LogicValue(true);
        IInput b = new LogicValue(false);

        IGate or = new OrGate();
        or.AddInput(a);
        or.AddInput(b);
        
        Assert.That(or.OutputValue, Is.EqualTo(true));
    }
    
    [Test]
    public void TestOrGateOutputValueShouldBeFalse()
    {
        IInput a = new LogicValue(false);
        IInput b = new LogicValue(false);

        IGate or = new OrGate();
        or.AddInput(a);
        or.AddInput(b);
        
        Assert.That(or.OutputValue, Is.EqualTo(false));
    }

    [Test]
    public void TestNotGateValueShouldBeFalse()
    {
        IInput a = new LogicValue(true);
        
        IGate not = new NotGate();
        not.AddInput(a);
        
        Assert.That(not.OutputValue, Is.EqualTo(false));
    }

    [Test]
    public void TestNotGateValueShouldBeTrue()
    {
        IInput a = new LogicValue(false);
        
        IGate not = new NotGate();
        not.AddInput(a);
        
        Assert.That(not.OutputValue, Is.EqualTo(true));
    }
    
    [Test]
    public void TestCircuit1ShouldOutputTrue()
    {
        IInput a = new LogicValue(false);
        IInput b = new LogicValue(true);
        IInput c = new LogicValue(false);
        
        IGate not = new NotGate();
        not.AddInput(c);
        
        IGate or = new OrGate();
        or.AddInput(a);
        or.AddInput(b);

        IGate and = new AndGate();
        and.AddInput(or);
        and.AddInput(not);
        and.AddInput(b);
        
        Assert.That(and.OutputValue, Is.EqualTo(true));
    }

    [Test]
    public void TestCircuitShouldOutputFalse()
    {
        IInput a = new LogicValue(false);
        IInput b = new LogicValue(true);
        IInput c = new LogicValue(true);

        IGate and1 = new AndGate();
        and1.AddInput(a);
        and1.AddInput(b);

        IGate not = new NotGate();
        not.AddInput(c);

        IGate and2 = new AndGate();
        and2.AddInput(and1);
        and2.AddInput(not);
        and2.AddInput(b);
        
        Assert.That(and2.OutputValue, Is.EqualTo(false));
    }
}