﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TracingViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.ViewModels.Options
{
    using Scorchio.Infrastructure.Services;
    using Scorchio.Infrastructure.Wpf;
    using Services.Interfaces;
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    ///  Defines the TracingViewModel type.
    /// </summary>
    public class TracingViewModel : NinjaBaseViewModel
    {
        /// <summary>
        /// The application service.
        /// </summary>
        private readonly IApplicationService applicationService;

        /// <summary>
        /// The message box service.
        /// </summary>
        private readonly IMessageBoxService messageBoxService;

        /// <summary>
        /// The trace output enabled.
        /// </summary>
        private bool traceOutputEnabled;

        /// <summary>
        /// The log to file.
        /// </summary>
        private bool logToFile;

        /// <summary>
        /// The display errors.
        /// </summary>
        private bool displayErrors;

        /// <summary>
        /// The log file path.
        /// </summary>
        private string logFilePath;

        /// <summary>
        /// The error file path.
        /// </summary>
        private string errorFilePath;

        /// <summary>
        /// The output logs to read me.
        /// </summary>
        private bool outputLogsToReadMe;

        /// <summary>
        /// The extended logging.
        /// </summary>
        private bool extendedLogging;

        /// <summary>
        /// Initializes a new instance of the <see cref="TracingViewModel" /> class.
        /// </summary>
        /// <param name="applicationService">The application service.</param>
        /// <param name="settingsService">The settings service.</param>
        /// <param name="messageBoxService">The message box service.</param>
        public TracingViewModel(
            IApplicationService applicationService,
            ISettingsService settingsService,
            IMessageBoxService messageBoxService)
            : base(settingsService)
        {
            this.applicationService = applicationService;
            this.messageBoxService = messageBoxService;

            this.Init();
        }

        /// <summary>
        /// Gets or sets the language dictionary.
        /// </summary>
        public ResourceDictionary LanguageDictionary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [trace output enabled].
        /// </summary>
        public bool TraceOutputEnabled
        {
            get { return this.traceOutputEnabled; }
            set { this.SetProperty(ref this.traceOutputEnabled, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [log to file].
        /// </summary>
        public bool LogToFile
        {
            get { return this.logToFile; }
            set { this.SetProperty(ref this.logToFile, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display errors].
        /// </summary>
        public bool DisplayErrors
        {
            get { return this.displayErrors; }
            set { this.SetProperty(ref this.displayErrors, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [eextended logging].
        /// </summary>
        public bool ExtendedLogging
        {
            get { return this.extendedLogging; }
            set { this.SetProperty(ref this.extendedLogging, value); }
        }

        /// <summary>
        /// Gets or sets the log file path.
        /// </summary>
        public string LogFilePath
        {
            get { return this.logFilePath; }
            set { this.SetProperty(ref this.logFilePath, value); }
        }

        /// <summary>
        /// Gets or sets the error file path.
        /// </summary>
        public string ErrorFilePath
        {
            get { return this.errorFilePath; }
            set { this.SetProperty(ref this.errorFilePath, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [output logs to read me].
        /// </summary>
        public bool OutputLogsToReadMe
        {
            get { return this.outputLogsToReadMe; }
            set { this.SetProperty(ref this.outputLogsToReadMe, value); }
        }

        /// <summary>
        /// Gets the clear log command.
        /// </summary>
        public ICommand ClearLogCommand
        {
            get { return new RelayCommand(this.ClearLog); }
        }

        /// <summary>
        /// Gets the view log command.
        /// </summary>
        public ICommand ViewLogCommand
        {
            get { return new RelayCommand(this.ViewLog); }
        }

        /// <summary>
        /// Gets the clear error log command.
        /// </summary>
        public ICommand ClearErrorLogCommand
        {
            get { return new RelayCommand(this.ClearErrorLog); }
        }

        /// <summary>
        /// Gets the view error log command.
        /// </summary>
        public ICommand ViewErrorLogCommand
        {
            get { return new RelayCommand(this.ViewErrorLog); }
        }

        /// <summary>
        /// Inits this instance.
        /// </summary>
        internal void Init()
        {
            this.TraceOutputEnabled = this.SettingsService.LogToTrace;
            this.LogToFile = this.SettingsService.LogToFile;
            this.LogFilePath = this.SettingsService.LogFilePath;
            this.DisplayErrors = this.SettingsService.DisplayErrors;
            this.ErrorFilePath = this.SettingsService.ErrorFilePath;
            this.OutputLogsToReadMe = this.SettingsService.OutputLogsToReadMe;
            this.ExtendedLogging = this.SettingsService.ExtendedLogging;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        internal void Save()
        {
            this.SettingsService.LogToTrace = this.TraceOutputEnabled;
            this.SettingsService.LogToFile = this.LogToFile;
            this.SettingsService.LogFilePath = this.LogFilePath;
            this.SettingsService.DisplayErrors = this.DisplayErrors;
            this.SettingsService.ErrorFilePath = this.ErrorFilePath;
            this.SettingsService.OutputLogsToReadMe = this.OutputLogsToReadMe;
            this.SettingsService.ExtendedLogging = this.ExtendedLogging;
        }

        /// <summary>
        /// Clears the log.
        /// </summary>
        internal void ClearLog()
        {
            this.applicationService.ClearLogFile();

            this.messageBoxService.Show(
                "The trace log has been cleared.",
                Constants.Settings.ApplicationName);
        }

        /// <summary>
        /// Views the log.
        /// </summary>
        internal void ViewLog()
        {
            this.applicationService.ViewLogFile();
        }

        /// <summary>
        /// Clears the error log.
        /// </summary>
        private void ClearErrorLog()
        {
            this.applicationService.ClearErrorLogFile();

            this.messageBoxService.Show(
                "The error log has been cleared.",
                Constants.Settings.ApplicationName);
        }

        /// <summary>
        /// Views the error log.
        /// </summary>
        private void ViewErrorLog()
        {
            this.applicationService.ViewErrorLogFile();
        }
    }
}
