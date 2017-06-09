using System;

namespace SimpleBuild
{
    public class MoreAboutTesting : IMoreAboutTesting
    {
        public bool IsStringLong(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentOutOfRangeException(nameof(input));
            }

            if (input.Length > 5)
            {
                return true;
            }

            return false;
        }
    }
}
