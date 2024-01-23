// Violating LSP
public class Bird
{
    public virtual void Fly()
    {
        // Implementation for flying
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Ostriches can't fly.");
    }
}

// Applying LSP
public abstract class Bird
{
}

public class FlyingBird : Bird
{
    public virtual void Fly()
    {
        // Implementation for flying
    }
}

public class Ostrich : Bird
{
    // Ostrich doesn't implement Fly and doesn't need to
}