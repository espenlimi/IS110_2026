public class Examples
{
    string[] navn = new string[] { "Anna", null, "Ola" };
    public ReturnObject Run(int index)
    {

        if (index < 0 || index >= navn.Length)
            return new ReturnObject { HadError = true };


        return new ReturnObject { Name = navn[index] };
    }
}

public class ReturnObject 
{
    public string Name { get; set; }
    public bool HadError { get; set; } = false;
}