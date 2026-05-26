public class Logger
{
	public void Log(string message)
	{
		File.AppendAllText("log.txt", message + Environment.NewLine);
	}
}

git add Logger.cs
git commit -m 