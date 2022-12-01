using System;

namespace MVVMCalculator.Helpers
{
    internal static class Utility
    {
        static internal double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

    }
}
