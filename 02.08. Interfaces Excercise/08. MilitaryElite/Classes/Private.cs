﻿public class Private : Soldier, IPrivate
{
    public Private(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    private double salary;

    public double Salary
    {
        get
        {
            return salary;
        }

        private set
        {
            salary = value;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()} Salary: {this.Salary:f2}";
    }
}