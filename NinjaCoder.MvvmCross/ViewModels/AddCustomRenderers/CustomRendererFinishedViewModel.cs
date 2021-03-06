﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the CustomRendererFinishedViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.ViewModels.AddCustomRenderers
{
    using Scorchio.Infrastructure.Wpf.ViewModels.Wizard;
    using Services.Interfaces;

    /// <summary>
    /// Defines the CustomRendererFinishedViewModel type.
    /// </summary>
    public class CustomRendererFinishedViewModel : BaseWizardStepViewModel
    {
        /// <summary>
        /// The caching service.
        /// </summary>
        private readonly ICachingService cachingService;

        /// <summary>
        /// The message.
        /// </summary>
        private string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRendererFinishedViewModel"/> class.
        /// </summary>
        /// <param name="cachingService">The caching service.</param>
        public CustomRendererFinishedViewModel(ICachingService cachingService)
        {
            this.cachingService = cachingService;
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.SetProperty(ref this.message, value); }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        public override string DisplayName
        {
            get { return "Finished"; }
        }

        /// <summary>
        /// Called when [initialize].
        /// </summary>
        public override void OnInitialize()
        {
            this.Message = this.cachingService.Messages["CustomRendererFinishMessage"];
        }
    }
}
