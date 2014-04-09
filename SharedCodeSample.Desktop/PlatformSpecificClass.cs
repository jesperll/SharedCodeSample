using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSample
{
    public class PlatformSpecificClass
    {
        public string GetPlatformName()
        {
            return "Desktop";
        }
    }

    public partial class PartialClass
    {
        public string GetPlatformNameImpl()
        {
            return "Desktop";
        }
    }
}
