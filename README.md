# ASF-IPC-CLI-Wrapper

Simple ArchiSteamFarm IPC command CLI wrapper, no more opening browser.

## How this works

It sends POST requests to API `Api/Command` then returns the result.

## Build

Install dotnet 6.0 SDK first, you can find installation packages/guides [here](https://dotnet.microsoft.com/download).

### Publish

```
dotnet publish -c Release -o /your/path/here -r [win10-x64/osx-x64/linux-x64] --sc
```

## Usage

Fill your IPC url and password in config.json, then run the executable file.

Currently supported IPC commands:

- Addlicense 
  - Usage: `ASF add [Bot1,Bot2...] [SubID1,AppID1,SubID2...]`
- Redeem
  - Usage: `ASF red [Bot] [Key1,Key2...]`
- 2fa 
  - Usage: `ASF 2fa [Bot]`
- play
  - Usage: `ASF pl [Bot] [AppID/Game Name]`
- reset
  - Usage: `ASF rst [Bot]`

