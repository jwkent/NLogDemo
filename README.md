# NLogDemo
How to use NLog and change log level programatically using WPF.

	private readonly Logger _logger = LogManager.GetCurrentClassLogger();

	_logger.Factory.Configuration.LoggingRules[0].EnableLoggingForLevelLogLevel.Trace);
	_logger.Factory.ReconfigExistingLoggers();


