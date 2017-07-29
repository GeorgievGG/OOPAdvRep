using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{

    public Commando(string id, string firstName, string lastName, double salary, string corps, string[] missionParams) : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new Dictionary<string, string>();
        for (int i = 0; i < missionParams.Length; i += 2)
        {
            if (missionParams[i + 1] == "inProgress" || missionParams[i + 1] == "Finished")
            {
                missions.Add(missionParams[i], missionParams[i + 1]);
            }
        }
    }
    private Dictionary<string, string> missions;

    public IReadOnlyDictionary<string, string> Missions
    {
        get
        {
            return missions;
        }
    }

    public void CompleteMission(string codeName)
    {
        missions[codeName] = "Finished";
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        if (missions.Count > 0)
        {
            sb.AppendLine("Missions:");
            foreach (var msn in missions)
            {
                sb.AppendLine($"  Code Name: {msn.Key} State: {msn.Value}");
            }
        }
        else
        {
            sb.Append("Missions:");
        }
        return sb.ToString();
    }
}