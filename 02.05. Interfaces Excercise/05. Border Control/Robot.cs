public class Robot : IServant
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.ID = id;
    }

    private string model;
    private string id;

    public string Model
    {
        get
        {
            return model;
        }

        private set
        {
            model = value;
        }
    }

    public string ID
    {
        get
        {
            return id;
        }

        private set
        {
            id = value;
        }
    }
}