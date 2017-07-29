using System.Collections.Generic;

public interface IEngineer
{
    IReadOnlyDictionary<string, int> Repairs { get; }
}