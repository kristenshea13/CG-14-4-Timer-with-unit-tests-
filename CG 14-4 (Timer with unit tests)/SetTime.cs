using System;

namespace CG_14_4__Timer_with_unit_tests_
{
    public static class SetTime
    {
        public static int TotalMilliseconds(string timeString)
        {
            string[] timestringSplit = timeString.Split(":");

            

            //try can for error handling...if set time not entered in proper format, method will return 0.
            try
            {
                int hours = 0;
                int minutes = 0;
                int seconds = 0;
                int totalMinutes = 0;
                int totalSeconds = 0;
                //parse out hours, minutes, seconds from user entry.

                for (int i = 0; i < timestringSplit.Length; i++)
                {
                    if (i == 0)
                        hours = int.Parse(timestringSplit[i]);
                    else if (i == 1)
                        minutes = int.Parse(timestringSplit[i]);
                    else
                        seconds = int.Parse(timestringSplit[i]);
                }

                //math to convert user-entered time to milliseconds
                totalMinutes = (hours * 60) + minutes;
                totalSeconds = (totalMinutes * 60) + seconds;
                return totalSeconds * 1000;
            }
            catch (Exception)
            {
                //return 0 if user doesn't enter data in correct format
                return 0;
            }
        }
    }
}