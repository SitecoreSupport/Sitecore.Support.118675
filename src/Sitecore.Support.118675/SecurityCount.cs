
using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    public static class SecurityCount
    {
        /// <summary>
        /// Gets the counter that counts the total number of access requests that have been denied.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter AccessDenied
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of access requests that have been granted.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter AccessGranted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of access requests that have been resolved.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter AccessResolved
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of access requests where the desired access would allow the caller to modify data (ie. update or delete an item).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ModifyRequests
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times that security has been programmatically disabled (using SecurityDisabler).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ProgrammaticDisabling
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times that security has been programmatically enabled (using SecurityEnabler).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ProgrammaticEnabling
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times that the current user has been switched programmatically (using SecuritySwitcher).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ProgrammaticUserSwitch
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of access requests where the desired access would allow the caller to read data (ie. reading an item).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ReadRequests
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of virutal users that have been built.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter VirtualUsersBuilt
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes static members of the <see cref="T:Sitecore.Diagnostics.AmountPerSecondCounters.SecurityCount" /> class.
        /// </summary>
        static SecurityCount()
        {
            try
            {
                SecurityCount.AccessDenied = new AmountPerSecondCounter("Access Denied / sec", "Sitecore.Security");
                SecurityCount.AccessGranted = new AmountPerSecondCounter("Access Granted / sec", "Sitecore.Security");
                SecurityCount.AccessResolved = new AmountPerSecondCounter("Access Resolved / sec", "Sitecore.Security");
                SecurityCount.ModifyRequests = new AmountPerSecondCounter("Modify Requests / sec", "Sitecore.Security");
                SecurityCount.ProgrammaticDisabling = new AmountPerSecondCounter("Programmatic Disabling / sec", "Sitecore.Security");
                SecurityCount.ProgrammaticEnabling = new AmountPerSecondCounter("Programmatic Enabling / sec", "Sitecore.Security");
                SecurityCount.ProgrammaticUserSwitch = new AmountPerSecondCounter("Programmatic User Switch / sec", "Sitecore.Security");
                SecurityCount.ReadRequests = new AmountPerSecondCounter("Read Requests / sec", "Sitecore.Security");
                SecurityCount.VirtualUsersBuilt = new AmountPerSecondCounter("Virtual Users Built / sec", "Sitecore.Security");
            }
            catch (System.Exception)
            {
            }
        }
    }
}
