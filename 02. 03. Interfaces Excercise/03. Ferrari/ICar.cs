public interface ICar
{
    string Model { get; }
    string DriverName { get; }
    string PushBrakes();
    string PushGas();
}