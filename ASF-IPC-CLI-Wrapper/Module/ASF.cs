using System.Text;
using System.Text.Json;
using ASF_IPC_CLI_Wrapper.Model;

namespace ASF_IPC_CLI_Wrapper.Module {
	internal static class ASF { 
		internal static async Task<string> Execute(ConfigLoadResult config, List<string> commands) {
			try {
				var sb = new StringBuilder();
				var client = new HttpClient();
				client.DefaultRequestHeaders.Add("Authentication", config.IPCPassword);
				string url = $"{config.IPCUrl}/Api/Command";

				foreach (var command in commands) {
					var content = new StringContent(JsonSerializer.Serialize(new ASFPostContent() { Command = command }), encoding: Encoding.UTF8, "application/json");
					var response = await client.PostAsync(url, content);
					var responseContent = JsonSerializer.Deserialize<ASFResponseContent>(await response.Content.ReadAsStringAsync()).Result.Replace("\n\n", "\n");
					sb.Append($"{responseContent}\n--------------------------------------\n");
				}

				return sb.ToString();
			} catch (Exception) {
				Output.Error("Execute() Error!");
				throw;
			}
		}
	}
}
