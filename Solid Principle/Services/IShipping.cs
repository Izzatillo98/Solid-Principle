namespace Solid_Principle.Services
{
    internal interface IShipping
    {
        int GetCost(Order order);
        int GetData(Order order); 
    }
}
