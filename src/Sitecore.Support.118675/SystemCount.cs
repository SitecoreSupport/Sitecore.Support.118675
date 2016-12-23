
using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    public static class SystemCount
    {
        /// <summary>
        /// Gets the counter that counts the total number of events that have been raised by the API.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter EventsEventsRaised
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of file watcher events that have been handled by the API.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter IOFileWatcherEvents
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the number of error messages that have been sent to the log.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LoggingErrorsLogged
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the number of fatal messages that have been sent to the log.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LoggingFatalsLogged
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the number of information messages that have been sent to the log.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LoggingInformationsLogged
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the number of warning messages that have been sent to the log.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LoggingWarningsLogged
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the number of audit messages that have been sent to the log.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LoggingAuditsLogged
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of methods that have been invoked through reflection.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ReflectionMethodsInvoked
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of objects that have been created using reflection.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ReflectionObjectsCreated
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of objects where the creation through reflection failed (due to unknown types or constructors).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ReflectionObjectsNotCreated
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of types that have been resolved using reflection.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ReflectionTypesResolved
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of types where the resolving through reflection failed (due to unknown types or other causes).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ReflectionTypesNotResolved
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of background threads that have been started by the API.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter ThreadingBackgroundThreadsStarted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of Packet instances that have been created.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter XmlPacketsCreated
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes static members of the <see cref="T:Sitecore.Diagnostics.AmountPerSecondCounters.SystemCount" /> class.
        /// </summary>
        static SystemCount()
        {
            try
            {
                SystemCount.EventsEventsRaised = new AmountPerSecondCounter("Events | Events Raised / sec", "Sitecore.System");
                SystemCount.IOFileWatcherEvents = new AmountPerSecondCounter("IO | File Watcher Events / sec", "Sitecore.System");
                SystemCount.LoggingErrorsLogged = new AmountPerSecondCounter("Logging | Errors Logged / sec", "Sitecore.System");
                SystemCount.LoggingFatalsLogged = new AmountPerSecondCounter("Logging | Fatals Logged / sec", "Sitecore.System");
                SystemCount.LoggingInformationsLogged = new AmountPerSecondCounter("Logging | Informations Logged / sec", "Sitecore.System");
                SystemCount.LoggingWarningsLogged = new AmountPerSecondCounter("Logging | Warnings Logged / sec", "Sitecore.System");
                SystemCount.LoggingAuditsLogged = new AmountPerSecondCounter("Logging | Audits Logged / sec", "Sitecore.System");
                SystemCount.ReflectionMethodsInvoked = new AmountPerSecondCounter("Reflection | Methods Invoked / sec", "Sitecore.System");
                SystemCount.ReflectionObjectsCreated = new AmountPerSecondCounter("Reflection | Objects Created / sec", "Sitecore.System");
                SystemCount.ReflectionObjectsNotCreated = new AmountPerSecondCounter("Reflection | Objects Not Created / sec", "Sitecore.System");
                SystemCount.ReflectionTypesResolved = new AmountPerSecondCounter("Reflection | Types Resolved / sec", "Sitecore.System");
                SystemCount.ReflectionTypesNotResolved = new AmountPerSecondCounter("Reflection | Types Not Resolved / sec", "Sitecore.System");
                SystemCount.ThreadingBackgroundThreadsStarted = new AmountPerSecondCounter("Threading | Background Threads Started / sec", "Sitecore.System");
                SystemCount.XmlPacketsCreated = new AmountPerSecondCounter("Xml | Packets Created / sec", "Sitecore.System");
            }
            catch (System.Exception)
            {
            }
        }
    }
}
