using ASF_IPC_CLI_Wrapper.Model;
using System.Text;

namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class Args {
		internal static ParseResult Parse(string[] args) {
			if (args.Length == 0) return new ParseResult() { HasArg = false, ErrMsg = "No argument specified!" };

			try {
				var result = ParseCommand(args);

				return result;
			} catch (Exception) {
				Output.Error("Parse() Error!");
				throw;
			}
		}

		internal static ParseResult ParseCommand(string[] args) {
			try {
				var parseReult = new ParseResult() { HasArg = true, ArgValid = true };
				var sb = new StringBuilder();

				foreach (var commandPart in args) {
					sb.Append($"{commandPart} ");
				}
				sb.Length -= 1;

				parseReult.Commands.Add(sb.ToString());

				return parseReult;
			} catch {
				Output.Error("ParseCommand() Error!");
				throw;
			}
		}
	}
}
