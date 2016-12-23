
using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    public static class JobsCount
    {
        /// <summary>
        /// Gets the counter that counts the total number of jobs that have been executed.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter JobsJobsExecuted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times a pipeline was aborted.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter PipelinesPipelinesAborted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times a pipeline was executed.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter PipelinesPipelinesExecuted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of processors that have been executed.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter PipelinesProcessorsExecuted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of items that have been queued for publishing.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter PublishingItemsQueued
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of publishing replacement operations that have been performed.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter PublishingReplacements
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times the CleanupAgent task has been run.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter TasksFileCleanups
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times the HtmlCacheClearAgent task has been run.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter TasksHtmlCacheClearings
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of times the PublishAgent task has been run.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter TasksPublishings
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of reminders that have been sent.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter TasksRemindersSent
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the counter that counts the total number of tasks that has been run.
        /// </summary>
        /// <value>
        /// The counter instance.
        /// </value>
        public static AmountPerSecondCounter TasksTasksExecuted
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes static members of the <see cref="T:Sitecore.Diagnostics.AmountPerSecondCounters.JobsCount" /> class.
        /// </summary>
        static JobsCount()
        {
            try
            {
                JobsCount.JobsJobsExecuted = new AmountPerSecondCounter("Jobs | Jobs Executed / sec", "Sitecore.Jobs");
                JobsCount.PipelinesPipelinesAborted = new AmountPerSecondCounter("Pipelines | Pipelines Aborted / sec", "Sitecore.Jobs");
                JobsCount.PipelinesPipelinesExecuted = new AmountPerSecondCounter("Pipelines | Pipelines Executed / sec", "Sitecore.Jobs");
                JobsCount.PipelinesProcessorsExecuted = new AmountPerSecondCounter("Pipelines | Processors Executed / sec", "Sitecore.Jobs");
                JobsCount.PublishingItemsQueued = new AmountPerSecondCounter("Publishing | Items Queued / sec", "Sitecore.Jobs");
                JobsCount.PublishingReplacements = new AmountPerSecondCounter("Publishing | Replacements / sec", "Sitecore.Jobs");
                JobsCount.TasksFileCleanups = new AmountPerSecondCounter("Tasks | File Cleanups / sec", "Sitecore.Jobs");
                JobsCount.TasksHtmlCacheClearings = new AmountPerSecondCounter("Tasks | Html Cache Clearings / sec", "Sitecore.Jobs");
                JobsCount.TasksPublishings = new AmountPerSecondCounter("Tasks | Publishings / sec", "Sitecore.Jobs");
                JobsCount.TasksRemindersSent = new AmountPerSecondCounter("Tasks | Reminders Sent / sec", "Sitecore.Jobs");
                JobsCount.TasksTasksExecuted = new AmountPerSecondCounter("Tasks | Tasks Executed / sec", "Sitecore.Jobs");
            }
            catch (System.Exception)
            {
            }
        }
    }
}
