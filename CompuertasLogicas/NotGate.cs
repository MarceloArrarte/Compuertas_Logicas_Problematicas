namespace CompuertasLogicas;

public class NotGate : IGate
{
    private IInput input;

    public IReadOnlyList<IInput> Inputs
    {
        get { return [input]; }
    }

    public bool OutputValue
    {
        get
        {
            return !input.OutputValue;
        }
    }

    public void AddInput(IInput input)
    {
        this.input = input;
    }
}