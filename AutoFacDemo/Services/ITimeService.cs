using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacDemo.Services
{
    public interface ITimeService
    {
        string GetNow();
    }

    public class TimeService : ITimeService
    {
        public string GetNow()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
