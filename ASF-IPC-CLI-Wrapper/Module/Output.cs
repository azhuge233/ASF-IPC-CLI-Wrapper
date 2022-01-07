namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class Output {
		internal static void Usage() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Usage (Ignore cases) :");
			Console.WriteLine(
				"  add - addlicense command\n\tUsage: add [BotName1,BotName2...] [SubID1,AppID2,SubIDd3...]\n" +
				"  red - redeem command\n\tUsage: red [BotName] [Key1,Key2,Key3...]\n" +
				"  2fa - two factor code command\n\tUsage: 2fa [BotName]\n" +
				"  pl - play command\n\tUsage: pl [BotName] [AppID/Game Name]\n" +
				"  rst - reset command\n\tUsage: rst [BotName]"
			);
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
