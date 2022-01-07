using ASF_IPC_CLI_Wrapper.Module;

namespace ASF_IPC_CLI_Wrapper {
	internal class Program {

		static async Task Main(string[] args) {
			try {
				var configResult = Config.GetConfig();
				if (!configResult.Item2.IsValid) {
					Output.Warning(configResult.Item2.ErrMsg);
					return;
				}
				
				var parseResult = Args.Parse(args);
				if (parseResult.HasArg && parseResult.ArgValid)
					Output.Info(await ASF.Execute(configResult.Item1, parseResult.Commands));
				else {
					Output.Warning(parseResult.ErrMsg);
					Output.Usage();
				}

			} catch (Exception e) {
				Output.Error(e.Message);
			}
		}
	}
}