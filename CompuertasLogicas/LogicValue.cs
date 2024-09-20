namespace CompuertasLogicas;

public class LogicValue : IInput
{
    private bool outputValue;
    public bool OutputValue
    {
        get { return true; }
    }

    public LogicValue(bool value)
    {
        outputValue = value;
    }
}