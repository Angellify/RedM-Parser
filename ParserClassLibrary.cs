using System.ComponentModel;

namespace ParserLibrary
{
    public class PathClass
    {
        static string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string initialPath = Path.Combine(applicationData, "RedM", "RedM.app", "logs");
        public static string GetInitialPath(string filePath)
        {
            if (Directory.Exists(initialPath))
            {
                filePath = initialPath;
                return filePath;

            }

            else if (!Directory.Exists(initialPath))
            {
                filePath = "RedM Logs Folder";
                return filePath;
            }
            else
                return string.Empty;
        }

        public static bool bHasRightPath(string filePath)
        {
            if (Directory.Exists(filePath))
                return true;
            else if (!Directory.Exists(filePath))
                return false;
            else return false;
        }

    }

    public class ParserClass
    {

        public static string GetSessionTag(string redmPath)
        {
            DirectoryInfo dir = new DirectoryInfo(redmPath);
            var chatlogPath = dir.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
            var lastSession = chatlogPath.ToString();
            var sessionTag = lastSession.Substring(lastSession.IndexOf("-"));

            return sessionTag;
        }

        public static BindingList<string> ParseLog(string filePath)
        {
            DirectoryInfo dir = new DirectoryInfo(filePath);
            BindingList<string> logLines = new BindingList<string>();

            if (dir != null && PathClass.bHasRightPath(filePath))
            {
                var chatlogPath = dir.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                var lastSession = chatlogPath.ToString();
                lastSession.Substring(lastSession.IndexOf("-"));
    
                string[] validLines = { "says:", "*", "PM", "whispers", "((", "))", "[low]:", "shouts:"};

                if (chatlogPath != null)
                {
                    var chatlog = File.ReadAllLines(chatlogPath.FullName);
                    
                    foreach (string line in chatlog)
                    {
                        foreach (string validLine in validLines)
                        {
                            if (line.Contains(validLine))
                            {
                                var validString = line.Substring(line.IndexOf('/') + 2);
                                logLines.Add(validString);
                                break;
                            }

                        }
                    }

                }
            }
            return logLines;

        }
    }
}