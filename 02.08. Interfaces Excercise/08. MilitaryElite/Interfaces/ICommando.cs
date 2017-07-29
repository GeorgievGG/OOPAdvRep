using System.Collections.Generic;

public interface ICommando
{
    IReadOnlyDictionary<string, string> Missions { get; }

    void CompleteMission(string codeName);
}
