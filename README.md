# ASF-IPC-CLI-Wrapper

Simple ArchiSteamFarm IPC command CLI wrapper, no more opening browser or Steam Chat.

## How this works

It sends POST requests to ASF IPC's API endpoint `Api/Command` then returns the result.

## Usage

Download pre-build packages in release page.

Fill your IPC url and password in config.json, then run the executable file.

```bash
ASF [your ASF instance available commands]
# eg: ASF 2fa asf
#     ASF addlicense [Bot1],[Bot2],... <AppID>,<SubID>,...
```

## Build

Install dotnet 7.0 SDK first, you can find installation packages/guides [here](https://dotnet.microsoft.com/download).

### Publish

```
dotnet publish -c Release -o /your/path/here -r [win10-x64/osx-x64/linux-x64] --sc
```
