namespace CompuertasLogicas;

public class OrGate : IGate
{
    private List<IInput> inputs;

    public IReadOnlyList<IInput> Inputs
    {
        get { return inputs; }
    }

    public bool OutputValue
    {
        get
        {
            foreach (IInput input in inputs)
            {
                if (!input.OutputValue)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public void AddInput(IInput input)
    {
        inputs.Add(input);
    }
}