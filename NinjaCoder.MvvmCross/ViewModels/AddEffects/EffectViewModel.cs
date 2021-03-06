﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the EffectViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.ViewModels.AddEffects
{
    using Factories.Interfaces;
    using Scorchio.Infrastructure.Extensions;
    using Scorchio.Infrastructure.Services;
    using Scorchio.Infrastructure.Wpf.ViewModels.Wizard;
    using Scorchio.VisualStudio.Entities;
    using Services.Interfaces;
    using System.Collections.Generic;

    /// <summary>
    ///  Defines the EffectViewModel type.
    /// </summary>
    public class EffectViewModel : BaseWizardStepViewModel
    {
        /// <summary>
        /// The message box service.
        /// </summary>
        private readonly IMessageBoxService messageBoxService;

        /// <summary>
        /// The settings service.
        /// </summary>
        private readonly ISettingsService settingsService;

        /// <summary>
        /// The caching service.
        /// </summary>
        private readonly ICachingService cachingService;
        
        /// <summary>
        /// The effect factory
        /// </summary>
        private readonly IEffectFactory effectFactory;

        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        
        /// <summary>
        /// The append effect to name.
        /// </summary>
        private bool appendEffectToName;

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectViewModel" /> class.
        /// </summary>
        /// <param name="messageBoxService">The message box service.</param>
        /// <param name="settingsService">The settings service.</param>
        /// <param name="cachingService">The caching service.</param>
        /// <param name="effectFactory">The effect factory.</param>
        public EffectViewModel(
            IMessageBoxService messageBoxService,
            ISettingsService settingsService,
            ICachingService cachingService,
            IEffectFactory effectFactory)
        {
            this.messageBoxService = messageBoxService;
            this.settingsService = settingsService;
            this.cachingService = cachingService;
            this.effectFactory = effectFactory;
            this.Init();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get { return this.name?.CaptialiseFirstCharacter(); }
            set { this.SetProperty(ref this.name, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [append effect to name].
        /// </summary>
        public bool AppendEffectToName
        {
            get { return this.appendEffectToName; }
            set { this.SetProperty(ref this.appendEffectToName, value); }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        public override string DisplayName
        {
            get { return "Effect"; }
        }

        /// <summary>
        /// Gets the name of the requested.
        /// </summary>
        public string RequestedName
        {
            get
            {
                string requestedName = this.name.CaptialiseFirstCharacter();

                if (this.appendEffectToName)
                {
                    return requestedName + "Effect";
                }

                return requestedName;
            }
        }

        /// <summary>
        /// Determines whether this instance [can move to next page].
        /// </summary>
        /// <returns>True or false.</returns>
        public override bool CanMoveToNextPage()
        {
            if (string.IsNullOrEmpty(this.name))
            {
                this.messageBoxService.Show(
                    "Please enter all the required fields",
                    Constants.Settings.ApplicationName);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Called when [save].
        /// </summary>
        public override void OnSave()
        {
            base.OnSave();

            this.settingsService.AutomaticallyAddEffect = this.appendEffectToName;

            IEnumerable<TextTemplateInfo> templateInfos = this.effectFactory.GetTextTemplates(
                    this.RequestedName,
                    this.settingsService.EffectDirectory);

            string message = string.Empty;

            foreach (TextTemplateInfo textTemplateInfo in templateInfos)
            {
                message += textTemplateInfo.ProjectFolder + @"\" + textTemplateInfo.FileName + " will be added to the  " + textTemplateInfo.ProjectSuffix + " project.\r\n\r\n";
            }

            this.cachingService.Messages["EffectFinishMessage"] = message;
        }

        /// <summary>
        /// Called when [initialize].
        /// </summary>
        internal void Init()
        {
            this.AppendEffectToName = this.settingsService.AutomaticallyAddEffect;
        }
    }
}
