namespace UnityEngine;

public interface ILogHandler
{

	public void LogException(Exception exception, object context) { }

	public void LogFormat(LogType logType, object context, string format, Object[] args) { }

}

