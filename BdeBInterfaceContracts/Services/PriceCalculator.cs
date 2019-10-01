namespace BdeBInterfaceContracts.Services
{
    public interface IPriceCalculator
    {
        // What do we want to do, here?
        // Calculate the price of a Product!

        // Write the signature for a method that calculates the price of a
        // Product.
    }

    public class PriceCalculator : IPriceCalculator
    {
        // Write the implementation for this interface for non-members
        // customers.
    }

    public class AdvantagesMemberPriceCalculator : IPriceCalculator
    {
        private const decimal StandardPriceMultiplier = 0.9m;

        // Write the implementation for this interface for Advantages members
        // customers. They get a 10% reduction on every Products. Use the
        // constant above to do the calculation!
    }
}
