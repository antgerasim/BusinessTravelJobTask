using System.Runtime.Serialization;

namespace BusinessTravelJobTask.ViewModels
{

    public interface IRootObject
    {
        bool success { get; set; }

        int elapsedMilliseconds { get; set; }

    }
}