namespace lib;

public class Screen
{
    private readonly string _message;

    public Screen(string message)
    {
        _message = message;
    }

    public override string ToString()
    {
        return _message;
    }
}