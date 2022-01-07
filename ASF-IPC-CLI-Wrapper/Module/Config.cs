using System.Text.Json;
using ASF_IPC_CLI_Wrapper.Model;

namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class Config {
		private static readonly string ConfigPath = $"{AppDomain.CurrentDomain.BaseDirectory}config.json";

		private static ConfigValidateResult Validate(ConfigLoadResult config) {
			try {
				var result = new ConfigValidateResult() { IsValid = true, ErrMsg = "" };

				if (string.IsNullOrEmpty(config.IPCUrl) || string.IsNullOrEmpty(config.IPCPassword)) {
					result.IsValid = false;
					result.ErrMsg = "Please set IPC url and password in App.config first.";
				}
				if (config.IPCUrl.EndsWith('/')) {
					result.IsValid = false;
					result.ErrMsg = "Do NOT add any additional slash('/') at the end of the URL string.";
				}

				return result;
			} catch (Exception) {
				Output.Error("Validate() Error!");
				throw;
			}
		}

		internal static Tuple<ConfigLoadResult, ConfigValidateResult> GetConfig() {
			try {
				var config = JsonSerializer.Deserialize<ConfigLoadResult>(File.ReadAllText(ConfigPath));

				return new Tuple<ConfigLoadResult, ConfigValidateResult>(config, Validate(config));
			} catch (Exception) {
				Output.Error("GetConfig() Error!");
				throw;
			}
		}
	}
}
