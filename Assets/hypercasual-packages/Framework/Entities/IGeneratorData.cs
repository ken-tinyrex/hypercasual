namespace Hypercasual.Framework
{
    public interface IGeneratorData
    {
        long payoutAmount { get; }
        long upgradeAmount { get; }
        double payoutDuration { get; }
    }
}