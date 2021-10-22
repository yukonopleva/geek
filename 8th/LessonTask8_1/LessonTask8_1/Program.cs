using System;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace LessonTask8_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(ConfigurationManager.AppSettings["Greetings"]);

			Configuration settings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = settings.FilePath };

			Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

			if (string.IsNullOrEmpty(config.AppSettings.Settings["UserName"].Value))
			{
				var username = config.AppSettings.Settings["UserName"].Value;
				Console.WriteLine("Please input your name:");
				username = Console.ReadLine();
				config.AppSettings.Settings["UserName"].Value = $"{username}";
				config.Save();

				var userage = config.AppSettings.Settings["UserAge"].Value;
				Console.WriteLine("Please input your age:");
				userage = Console.ReadLine();
				config.AppSettings.Settings["UserAge"].Value = $"{userage}";
				config.Save();

				var userocc = config.AppSettings.Settings["UserOccupation"].Value;
				Console.WriteLine("Please input your occupation:");
				userocc = Console.ReadLine();
				config.AppSettings.Settings["UserOccupation"].Value = $"{userocc}";
				config.Save();
			}
			else
			{
				Console.WriteLine($"Name:{ConfigurationManager.AppSettings["UserName"]}, Age:{ConfigurationManager.AppSettings["UserAge"]}, Occupation:{ConfigurationManager.AppSettings["UserOccupation"]}");
			}
		}
	}
}
