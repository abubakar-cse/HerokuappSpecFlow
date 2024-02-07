using System;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;

namespace HerokuappSpecFlow.Framework.Utils
{
	internal class FileUtils
	{
		protected static readonly JsonSettingsFile config = new("config.json");

		public static bool IsFileExists(string filePath)
		{
			AqualityServices.ConditionalWait.WaitForTrue(() => File.Exists(filePath));
			return File.Exists(filePath);
		}

		public static void DeleteFileIfExists(FileInfo fileName)
		{
			if (fileName.Exists)
				fileName.Delete();
		}

		public static string GetAbsoluateFilePath(string filePath) => new FileInfo(filePath).FullName;
	}
}

