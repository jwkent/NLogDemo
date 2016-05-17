using System.Windows;
using NLog;

namespace NLogDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogging_Click(object sender, RoutedEventArgs e)
        {
            // Turn on FATAL through TRACE.
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Fatal);
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Error);
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Warn);
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Info);
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Debug);
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Trace);

            _logger.Factory.ReconfigExistingLoggers();

        }

        private void btnLoggingErrorsOnly_Click(object sender, RoutedEventArgs e)
        {
            // Turn on FATAL and ERROR
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Fatal);
            _logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevel(LogLevel.Error);
            // Turn off TRACE through WARN
            _logger.Factory.Configuration.LoggingRules[0].DisableLoggingForLevel(LogLevel.Warn);
            _logger.Factory.Configuration.LoggingRules[0].DisableLoggingForLevel(LogLevel.Info);
            _logger.Factory.Configuration.LoggingRules[0].DisableLoggingForLevel(LogLevel.Debug);
            _logger.Factory.Configuration.LoggingRules[0].DisableLoggingForLevel(LogLevel.Trace);

            _logger.Factory.ReconfigExistingLoggers();
        }

        private void btnLoggingCreateErrors_Click(object sender, RoutedEventArgs e)
        {
            _logger.Fatal("Fatal occurred.");
            _logger.Error("Error occurred.");
            _logger.Warn("Warn occurred.");
            _logger.Info("Info occurred.");
            _logger.Debug("Debug occurred.");
            _logger.Trace("Trace occurred.");
        }
    }
}
