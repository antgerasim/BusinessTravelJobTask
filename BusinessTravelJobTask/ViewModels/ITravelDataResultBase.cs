namespace BusinessTravelJobTask.ViewModels
{
    public interface ITravelDataResultBase
    {
        int elapsedMilliseconds { get; set; }
        bool success { get; set; }
    }
}