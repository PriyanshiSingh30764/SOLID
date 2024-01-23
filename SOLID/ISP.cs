// Violating ISP
public interface IWorker
{
    void Work();
    void Eat();
}

public class HumanWorker : IWorker
{
    public void Work()
    {
        // Working
    }

    public void Eat()
    {
        // Eating during the break
    }
}

public class RobotWorker : IWorker
{
    public void Work()
    {
        // Working much more efficiently!
    }

    public void Eat()
    {
        // Robots do not eat, but the method must be implemented
        throw new NotImplementedException();
    }
}

// Applying ISP
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class HumanWorker : IWorkable, IEatable
{
    public void Work()
    {
        // Working
    }

    public void Eat()
    {
        // Eating during the break
    }
}

public class RobotWorker : IWorkable
{
    public void Work()
    {
        // Working much more efficiently!
    }
}