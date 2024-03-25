using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HCMIS.Data.AutoLogOut
{
    public class UserStateService
    {
        //Stopwatch
        private Stopwatch stopwatch;
        private System.Timers.Timer timer;
        private readonly double inactivityThresholdMinutes =2; // Adjust as needed
        public event Action InactivityTimeout;
        //Stopwatch

        public DateTime LastActivity { get; set; }
        public int _minutes = 5;

        //Stopwatch
        public UserStateService()
        {
            stopwatch = new Stopwatch();
            timer = new System.Timers.Timer(60000); // Check every 60 seconds (adjust as needed)
            timer.Elapsed += CheckInactivity;
            ResetTimer();
            timer.Start();
        }

        public void ResetTimer()
        {
            stopwatch.Restart();
        }

        private void CheckInactivity(object sender, ElapsedEventArgs e)
        {
            if (stopwatch.Elapsed.TotalMinutes >= inactivityThresholdMinutes)
            {
                InactivityTimeout?.Invoke();
                ResetTimer();
            }
        }
        //Stopwatch
        public bool IsUserActive()
        {
            // Check if the user has been active within the last 15 minutes
            return DateTime.Now - LastActivity < TimeSpan.FromMinutes(_minutes);
        }

        public TimeSpan TimeUntilLogoutWarning()
        {
            // Calculate the remaining time until automatic logout
            return TimeSpan.FromMinutes(_minutes) - (DateTime.Now - LastActivity);
        }

        public int RemainingInactivityTime()
        {
            // Calculate the remaining minutes until automatic logout
            var remainingMinutes = TimeSpan.FromMinutes(_minutes) - (DateTime.Now - LastActivity);
            return (int)Math.Ceiling(remainingMinutes.TotalMinutes);
        }

        public TimeSpan RemainingInactivityTime1()
        {
            return TimeSpan.FromMinutes(_minutes) - (DateTime.Now - LastActivity);
        }
    }
}
