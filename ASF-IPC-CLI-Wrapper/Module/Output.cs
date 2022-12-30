namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class Output {
		private const string NewUsageMsg = "Usage:\n" +
											"  ASF [Your ASF IPC supported commands]\n" +
											"  eg: ASF 2fa asf";

		internal static void Usage() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(NewUsageMsg);
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
