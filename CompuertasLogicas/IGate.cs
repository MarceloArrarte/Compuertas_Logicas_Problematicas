namespace CompuertasLogicas;

public interface IGate : IInput
{
    public IReadOnlyList<IInput> Inputs { get; }
    public void AddInput(IInput input);
}