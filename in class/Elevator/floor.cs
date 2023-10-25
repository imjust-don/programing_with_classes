public class Floor
{
    private int _FloorNumber;
    private int _VipFloor;

    public floor (int FloorNumber)
    {
        _FloorNumber = FloorNumber;
        _VipFloor = false;
    }

    public floor (int FloorNumber, bool VipFloor)
    {
        _FloorNumber = FloorNumber;
        _VipFloor = VipFloor;
    }

    public void DisplayFloor()
    {
        Console.Writeline($"You're on floor {_FloorNumber}");
    }


}