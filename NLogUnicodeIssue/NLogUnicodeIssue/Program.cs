using NLog;

namespace NLogUnicodeIssue
{
    internal class Program
    {
        internal static void Main()
        {
            Logger logger = LogManager.GetLogger("foo");
            logger.Info("Japanese characters: 昨夜のコン");
        }
    }
}
