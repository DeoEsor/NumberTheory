using System.Numerics;

namespace NumberTheory.Interfaces;

public interface IRandomGenerator
{
    BigInteger Generate();
}