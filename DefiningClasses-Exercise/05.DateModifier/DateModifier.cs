using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public static class DateModifier
    {
        public static int GetDiffBetweenTwoDates (string one, string two)
        {
            DateTime dateOne = DateTime.Parse(one);
            DateTime dateTwo = DateTime.Parse(two);

            TimeSpan diff = dateTwo - dateOne;
            return Math.Abs(diff.Days);

        }
    }
}
