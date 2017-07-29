using System;
public class TypeAttribute : Attribute
{
    public TypeAttribute(string type, string category, string description)
    {
        this.Type = type;
        this.Category = category;
        this.Description = description;
    }
    private string type;
    private string category;
    private string description;

    public string Type
    {
        get
        {
            return type;
        }

        set
        {
            type = value;
        }
    }

    public string Category
    {
        get
        {
            return category;
        }

        set
        {
            category = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    public override string ToString()
    {
        return $"Type = {this.Type}, Description = {this.Description}";
    }
}