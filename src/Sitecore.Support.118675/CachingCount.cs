
using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    public static class CachingCount
    {
        static CachingCount()
        {
            try
            {
                CacheClearings = new AmountPerSecondCounter("Cache Clearings / sec", "Sitecore.Caching", false);
                CacheHits = new AmountPerSecondCounter("Cache Hits / sec", "Sitecore.Caching", false);
                CacheMisses = new AmountPerSecondCounter("Cache Misses / sec", "Sitecore.Caching", false);
                DataCacheClearings = new AmountPerSecondCounter("Data Cache Clearings / sec", "Sitecore.Caching", false);
                DataCacheHits = new AmountPerSecondCounter("Data Cache Hits / sec", "Sitecore.Caching", false);
                DataCacheMisses = new AmountPerSecondCounter("Data Cache Misses / sec", "Sitecore.Caching", false);
                HtmlCacheClearings = new AmountPerSecondCounter("Html Cache Clearings / sec", "Sitecore.Caching", false);
                HtmlCacheHits = new AmountPerSecondCounter("Html Cache Hits / sec", "Sitecore.Caching", false);
                HtmlCacheMisses = new AmountPerSecondCounter("Html Cache Misses / sec", "Sitecore.Caching", false);
                PathCacheClearings = new AmountPerSecondCounter("Path Cache Clearings / sec", "Sitecore.Caching", false);
                PathCacheHits = new AmountPerSecondCounter("Path Cache Hits / sec", "Sitecore.Caching", false);
                PathCacheMisses = new AmountPerSecondCounter("Path Cache Misses / sec", "Sitecore.Caching", false);
                RegistryCacheClearings = new AmountPerSecondCounter("Registry Cache Clearings / sec", "Sitecore.Caching", false);
                RegistryCacheHits = new AmountPerSecondCounter("Registry Cache Hits / sec", "Sitecore.Caching", false);
                RegistryCacheMisses = new AmountPerSecondCounter("Registry Cache Misses / sec", "Sitecore.Caching", false);
                ViewStateCacheClearings = new AmountPerSecondCounter("View State Cache Clearings / sec", "Sitecore.Caching", false);
                ViewStateCacheHits = new AmountPerSecondCounter("View State Cache Hits / sec", "Sitecore.Caching", false);
                ViewStateCacheMisses = new AmountPerSecondCounter("View State Cache Misses / sec", "Sitecore.Caching", false);
                XslCacheClearings = new AmountPerSecondCounter("XslCache Clearings / sec", "Sitecore.Caching", false);
                XslCacheHits = new AmountPerSecondCounter("XslCache Hits / sec", "Sitecore.Caching", false);
                XslCacheMisses = new AmountPerSecondCounter("XslCache Misses / sec", "Sitecore.Caching", false);
            }
            catch (Exception)
            {
            }
        }

        public static AmountPerSecondCounter CacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter CacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter CacheMisses
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter DataCacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter DataCacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter DataCacheMisses
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter HtmlCacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter HtmlCacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter HtmlCacheMisses
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter PathCacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter PathCacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter PathCacheMisses
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter RegistryCacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter RegistryCacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter RegistryCacheMisses
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter ViewStateCacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter ViewStateCacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter ViewStateCacheMisses
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter XslCacheClearings
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter XslCacheHits
        {
            get;
            private set;
        }

        public static AmountPerSecondCounter XslCacheMisses
        {
            get;
            private set;
        }
    }
}
