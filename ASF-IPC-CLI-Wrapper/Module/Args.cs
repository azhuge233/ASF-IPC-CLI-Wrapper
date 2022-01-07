using ASF_IPC_CLI_Wrapper.Model;

namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class Args {
		internal static ParseResult Parse(string[] args) {
			try {
				if (args.Length == 0) return new ParseResult() { HasArg = false, ErrMsg = "No argument specified!"};

				var result = new ParseResult();

				switch (args[0].ToLower()) {
					case "add":
						result = Add(args);
						break;
					case "red":
						result = Red(args);
						break;
					case "2fa":
						result = TwoFA(args);
						break;
					case "pl":
						result = Play(args);
						break;
					case "rst":
						result = Reset(args);
						break;
					default:
						result.ArgValid = false;
						result.ErrMsg = "Invalid args!";
						break;
				}

				return result;
			} catch (Exception) {
				Output.Error("Parse() Error!");
				throw;
			}
		}

		internal static ParseResult Add(string[] args) {
			try {
				if (args.Length > 3) return new ParseResult() { ArgValid = false, ErrMsg = "Too Many Arguments!" };
				if (args.Length == 1 || args.Length == 2) return new ParseResult() { ArgValid = false, ErrMsg = "Lack Of Arguments!" };

				var parseResult = new ParseResult() { ArgValid = true, HasArg = true };

				foreach (string bot in args[1].Split(',')) { 
					parseResult.Commands.Add($"addlicense {bot} {args[2]}");
				}

				return parseResult;
			} catch (Exception) {
				Output.Error("Add() Error!");
				throw;
			}
		}

		internal static ParseResult Red(string[] args) {
			try {
				if (args.Length > 3) return new ParseResult() { ArgValid = false, ErrMsg = "Too Many Arguments!" };
				if (args.Length == 1 || args.Length == 2) return new ParseResult() { ArgValid = false, ErrMsg = "Lack Of Arguments!" };

				var parseResult = new ParseResult() { ArgValid = true, HasArg = true };

				parseResult.Commands.Add($"redeem {args[1]} {args[2]}");

				return parseResult;
			} catch (Exception) {
				Output.Error("Red() Error!");
				throw;
			}
		}

		internal static ParseResult TwoFA(string[] args) {
			try {
				if (args.Length > 2) return new ParseResult() { ArgValid = false, ErrMsg = "Too Many Arguments!" };
				if (args.Length == 1) return new ParseResult() { ArgValid = false, ErrMsg = "Lack Of Arguments!" };

				var parseResult = new ParseResult() { ArgValid = true, HasArg = true };

				parseResult.Commands.Add($"2fa {args[1]}");

				return parseResult;
			} catch (Exception) {
				Output.Error("TwoFA() Error!");
				throw;
			}
		}

		internal static ParseResult Play(string[] args) {
			try {
				if (args.Length > 3) return new ParseResult() { ArgValid = false, ErrMsg = "Too Many Arguments!" };
				if (args.Length == 1 || args.Length == 2) return new ParseResult() { ArgValid = false, ErrMsg = "Lack Of Arguments!" };

				var parseResult = new ParseResult() { ArgValid = true, HasArg = true };

				parseResult.Commands.Add($"play {args[1]} {args[2]}");

				return parseResult;
			} catch (Exception) {
				Output.Error("Play() Error!");
				throw;
			}
		}

		internal static ParseResult Reset(string[] args) {
			try {
				if (args.Length > 2) return new ParseResult() { ArgValid = false, ErrMsg = "Too Many Arguments!" };
				if (args.Length == 1) return new ParseResult() { ArgValid = false, ErrMsg = "Lack Of Arguments!" };

				var parseResult = new ParseResult() { ArgValid = true, HasArg = true };

				parseResult.Commands.Add($"reset {args[1]}");

				return parseResult;
			} catch (Exception) {
				Output.Error("Reset() Error!");
				throw;
			}
		}
	}
}
