using System;

namespace LessonTask2_4
{
	class Program
	{
		[Flags]
		public enum WeekDays
		{
			None = 0b_0000000,
			Monday = 0b_0000001,
			Tuesday = 0b_0000010,
			Wednesday = 0b_0000100,
			Thursday = 0b_0001000,
			Friday = 0b_0010000,
			Saturday = 0b_0100000,
			Sunday = 0b_1000000,
		}

		static void Main(string[] args)
		{
			WeekDays workDays = (WeekDays)0b_0111110;

			Console.WriteLine($"Working days: {workDays}");

		}
	}
}
