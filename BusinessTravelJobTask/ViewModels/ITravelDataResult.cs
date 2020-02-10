using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTravelJobTask.ViewModels
{
    public interface ITravelDataResult : ITravelDataResultBase
    {
        dynamic data { get; set; }
    }
}
