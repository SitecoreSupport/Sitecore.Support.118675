using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    public static class DataCount
    {
        static DataCount()
        {
            try
            {
                DataCount.DataClientDataReads = new AmountPerSecondCounter("Data | Client Data Reads / sec", "Sitecore.Data");
                DataCount.DataClientDataWrites = new AmountPerSecondCounter("Data | Client Data Writes / sec", "Sitecore.Data");
                DataCount.DataItemsAccessed = new AmountPerSecondCounter("Data | Items Accessed / sec", "Sitecore.Data");
                DataCount.DataPhysicalReads = new AmountPerSecondCounter("Data | Physical Reads / sec", "Sitecore.Data");
                DataCount.DataPhysicalWrites = new AmountPerSecondCounter("Data | Physical Writes / sec", "Sitecore.Data");
                DataCount.GlobalizationTextsTranslated = new AmountPerSecondCounter("Globalization | Texts Translated / sec", "Sitecore.Data");
                DataCount.GlobalizationTranslateFailed = new AmountPerSecondCounter("Globalization | Translate Failed / sec", "Sitecore.Data");
                DataCount.LinksFieldsExamined = new AmountPerSecondCounter("Links | Fields Examined / sec", "Sitecore.Data");
                DataCount.LinksDataRead = new AmountPerSecondCounter("Links | Data Read / sec", "Sitecore.Data");
                DataCount.LinksDataUpdated = new AmountPerSecondCounter("Links | Data Updated / sec", "Sitecore.Data");
                DataCount.SqlServerStreamOpenStreams = new AmountPerSecondCounter("SqlServerStream | Open Streams / sec", "Sitecore.Data");
                DataCount.StreamSharerOpenStreams = new AmountPerSecondCounter("StreamSharer | Open Streams / sec", "Sitecore.Data");
                DataCount.WorkflowActionsExecuted = new AmountPerSecondCounter("Workflow | Actions Executed / sec", "Sitecore.Data");
                DataCount.WorkflowSecurityResolved = new AmountPerSecondCounter("Workflow | Security Resolved / sec", "Sitecore.Data");
                DataCount.WorkflowStateChanges = new AmountPerSecondCounter("Workflow | State Changes / sec", "Sitecore.Data");
            }
            catch (System.Exception)
            {
            }
        }


        public static AmountPerSecondCounter DataClientDataReads
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of client data values that have been written.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter DataClientDataWrites
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of items that have been accessed.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter DataItemsAccessed
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of read operations that have been performed against the physical storage medium (typically a RDBMS).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter DataPhysicalReads
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of write operations that have been performed against the physical storage medium (typically a RDBMS).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter DataPhysicalWrites
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of texts that have been translated.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter GlobalizationTextsTranslated
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times a translate operation has failed (ie. the text was not in the dictionary).
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter GlobalizationTranslateFailed
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of fields that have been scanned for links.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LinksFieldsExamined
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of read operations that have been performed against the link database.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LinksDataRead
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of update operations that have been performed against the link database.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter LinksDataUpdated
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the current number of open SQL Server streams.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter SqlServerStreamOpenStreams
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the current number of open streams being handled by stream sharers.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter StreamSharerOpenStreams
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of workflow actions that have been executed.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter WorkflowActionsExecuted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times the workflow engine has resolved an access request.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter WorkflowSecurityResolved
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times that a workflow has changed state.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter WorkflowStateChanges
        {
            get;
            private set;
        }


    }
}
