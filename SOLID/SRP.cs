// Violating SRP
public class Order
{
    public void CalculateTotalSum() { /* ... */ }
    public void GetItems() { /* ... */ }
    public void GetItemCount() { /* ... */ }
    public void PrintOrder() { /* ... */ }
    public void ShowOrder() { /* ... */ }

    // This method violates SRP by handling persistence logic
    public void SaveOrder() { /* ... */ }
}

// Applying SRP
public class Order
{
    public void CalculateTotalSum() { /* ... */ }
    public void GetItems() { /* ... */ }
    public void GetItemCount() { /* ... */ }
    public void PrintOrder() { /* ... */ }
    public void ShowOrder() { /* ... */ }
}

public class OrderRepository
{
    public void SaveOrder(Order order) { /* ... */ }
}