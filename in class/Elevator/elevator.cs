public class Elevator
{
    private bool _DoorOpen;
    public List<Floor> _Floors = new List<Floor>();
    private Floor _ActiveFloor;

    public Elevator(Floor ActiveFloor)
    {
        _ActiveFloor = ActiveFloor;
        _DoorOpen = false;
    }
    
    public void AddFloor(Floor FloorNumber)
    {
        _ActiveFloor.add(FloorNumber);
    }

    public void ChangeFloor(Floor NewFloor)
    {
        if (!_DoorOpen)
        {
        _ActiveFloor = NewFloor;
        }
        else
        {
            Console.WriteLine("Doors are open");
        }
    }

    public void DoorStatus()
    {
        if (_DoorOpen)
        {
            _DoorOpen = false;
        }
        else
        {
            _DoorOpen = true;
        }

    }
} 