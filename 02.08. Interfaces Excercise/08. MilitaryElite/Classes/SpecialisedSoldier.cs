using System;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }
    private string corps;

    public string Corps
    {
        get
        {
            return corps;
        }

        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException();
            }
            corps = value;
        }
    }
}