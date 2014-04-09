using System;
using System.Diagnostics;

namespace SharedCodeSample
{
    public class SharedClass
    {
        public void WithDefines()
        {
#if DESKTOP
            Console.WriteLine("Desktop");
#elif WINDOWS_PHONE_APP
            Debug.WriteLine("Windows Phone");
#else
            throw new PlatformNotSupportedException("You need to reference the platform specific assembly from your app");
#endif
        }

        public string WithPlatformImplementation()
        {
            return new PlatformSpecificClass().GetPlatformName();
        }
    }

    public partial class PartialClass
    {
        public string GetPlatformName()
        {
            return GetPlatformNameImpl();
        }
    }
}
