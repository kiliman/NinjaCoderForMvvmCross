﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the PluginFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.Factories
{
    using Entities;
    using Interfaces;
    using Scorchio.Infrastructure.Translators;
    using Scorchio.VisualStudio.Services;
    using Services.Interfaces;
    using System.Linq;

    /// <summary>
    ///  Defines the PluginFactory type.
    /// </summary>
    public class PluginFactory : IPluginFactory
    {
        /// <summary>
        /// The pluginsTranslator.
        /// </summary>
        private readonly ITranslator<string, Plugins> pluginsTranslator;

        /// <summary>
        /// The caching service.
        /// </summary>
        private readonly ICachingService cachingService;

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginFactory" /> class.
        /// </summary>
        /// <param name="pluginsTranslator">The pluginsTranslator.</param>
        /// <param name="cachingService">The caching service.</param>
        public PluginFactory(
            ITranslator<string, Plugins> pluginsTranslator,
            ICachingService cachingService)
        {
            TraceService.WriteLine("PluginFactory::Constructor");

            this.pluginsTranslator = pluginsTranslator;
            this.cachingService = cachingService;
        }

        /// <summary>
        /// Gets the plugins.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>The plugins.</returns>
        public Plugins GetPlugins(string uri)
        {
            TraceService.WriteLine("PluginFactory::GetPlugins url=" + uri);

            if (this.cachingService.Plugins.ContainsKey(uri))
            {
                TraceService.WriteLine("Using cache");
                return this.cachingService.Plugins[uri];
            }

            Plugins plugins = this.pluginsTranslator.Translate(uri);

            if (plugins != null)
            {
                if (plugins.Items != null)
                {
                    TraceService.WriteLine("PluginFactory::GetPlugins pluginCount=" + plugins.Items.Count());
                    this.cachingService.Plugins.Add(uri, plugins);
                }
                else
                {
                    TraceService.WriteLine("PluginFactory::GetPlugins has no plugins");
                }
            }
            else
            {
                TraceService.WriteError("PluginFactory::GetPlugins is null url=" + uri);
            }

            return plugins;
        }
    }
}
