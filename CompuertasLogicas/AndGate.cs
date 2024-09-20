namespace CompuertasLogicas;

public class AndGate : IGate
{
    private List<IInput> inputs = new List<IInput>();

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
                else
                {
                    return true;
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