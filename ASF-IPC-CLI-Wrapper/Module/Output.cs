namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class Output {
		private const string UsageMsg = "Usage (Ignore cases) :\n" +
				"  add - addlicense command\n\tUsage: add [BotName1,BotName2...] [SubID1,AppID2,SubIDd3...]\n" +
				"  red - redeem command\n\tUsage: red [BotName] [Key1,Key2,Key3...]\n" +
				"  2fa - two factor code command\n\tUsage: 2fa [BotName]\n" +
				"  stat - status command\n\tUsage: stat [BotName]\n" +
				"  pl - play command\n\tUsage: pl [BotName] [AppID/Game Name]\n" +
				"  rsm - resume command\n\tUsage: rsm [BotName]\n" +
				"  rst - reset command\n\tUsage: rst [BotName]\n" +
				"  free - freegames command\n\t(https://github.com/maxisoft/ASFFreeGames plugin is needed)";

		internal static void Usage() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(UsageMsg);
			Console.ResetColor();
		}

		internal static void Error(string str) { 
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(str);
			Console.ResetColor();
		}
		internal static void Warning(string str) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(str);
			Console.ResetColor();
		}
		internal static void Info(string str) { 
			Console.WriteLine(str);
		}
	}
}
