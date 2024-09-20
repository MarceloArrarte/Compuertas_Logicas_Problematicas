namespace CompuertasLogicas;

public class Program
{
    public static void Main(string[] args)
    {
        IInput a = new LogicValue(true);
        IInput b = new LogicValue(false);
        IInput c = new LogicValue(false);
        
        IGate or = new OrGate();
        or.AddInput(a);
        or.AddInput(b);     // true

        IGate not = new NotGate();
        not.AddInput(c);    // true

        IGate and = new AndGate();
        and.AddInput(or);
        and.AddInput(not);  // true
        
        Console.WriteLine($"Resultado: {and.OutputValue}");
    }
}