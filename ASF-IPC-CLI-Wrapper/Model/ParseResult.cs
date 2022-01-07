namespace ASF_IPC_CLI_Wrapper.Model {
	internal class ParseResult {
		internal bool HasArg { get; set; }
		internal bool ArgValid { get; set; }
		internal List<string> Commands { get; set; } = new List<string>();
		internal string ErrMsg { get; set; } = string.Empty;
	}
}
