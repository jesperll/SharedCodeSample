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
            throw new PlatformNotSupportedException("You need to reference the platform specific assembly from your app");
        }
    }

    public partial class PartialClass
    {
        public string GetPlatformNameImpl()
        {
            throw new PlatformNotSupportedException("You need to reference the platform specific assembly from your app");
        }
    }
}
