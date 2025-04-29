using System.Text;

namespace Caliber_Components.Logs
{
    public static class ErrorLog
    {
        static int GetWeekNumber()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            return culture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }

        public static void MaintainLog(string exceptionMsg)
        {
            if (ApiKey.ErrFlag == 1)
            {
                try
                {
                    if (!Directory.Exists(ApiKey.Path))
                    {
                        Directory.CreateDirectory(ApiKey.Path);
                    }

                    string logFilePath = Path.Combine(ApiKey.Path, $"ErrorLog_W{GetWeekNumber()}.txt");
                    StringBuilder text2 = new StringBuilder();

                    if (File.Exists(logFilePath))
                    {
                        text2.Append(File.ReadAllText(logFilePath));
                    }

                    text2.AppendLine($"{Environment.NewLine+exceptionMsg} At::{DateTime.Now}");
                    File.WriteAllText(logFilePath, text2.ToString()+Environment.NewLine);
                    text2.Clear();
                    DeleteOldLogFiles();
                }
                catch (Exception ex)
                {
                    string logFilePath = Path.Combine(ApiKey.Path, "ErrorLog.txt");
                    StringBuilder text2 = new StringBuilder();

                    if (File.Exists(logFilePath))
                    {
                        text2.Append(File.ReadAllText(logFilePath));
                    }

                    text2.AppendLine($"{exceptionMsg} At::{DateTime.Now} Exception: {ex.Message}");
                    File.WriteAllText(logFilePath, text2.ToString());
                }
            }
        }

        static void DeleteOldLogFiles()
        {
            var logFiles = Directory.GetFiles(ApiKey.Path);

            foreach (var logFile in logFiles)
            {
                FileInfo fileInfo = new FileInfo(logFile);
                if (fileInfo.LastWriteTime < DateTime.Now.AddDays(-21) && fileInfo.Extension==".txt")
                {
                    try
                    {
                        File.Delete(logFile);                       
                    }
                    catch (Exception ex)
                    {
                        MaintainLog(ex.Message);
                    }
                }
            }
        }
    }
}
