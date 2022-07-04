# ASF-IPC-CLI-Wrapper

Simple ArchiSteamFarm IPC command CLI wrapper, no more opening browser.

## How this works

It sends POST requests to API `Api/Command` then returns the result.

## Usage

Download pre-build packages in release page.

Fill your IPC url and password in config.json, then run the executable file.

### Currently supported IPC commands

- addlicense 
  - `ASF add [Bot1,Bot2...] [SubID1,AppID1,SubID2...]`
- redeem
  - `ASF red [Bot] [Key1,Key2...]`
- 2fa 
  - `ASF 2fa [Bot]`
- stat
  - `ASF stat [Bot]`
- play
  - `ASF pl [Bot] [AppID/Game Name]`
- reset
  - `ASF rst [Bot]`

## Build

Install dotnet 6.0 SDK first, you can find installation packages/guides [here](https://dotnet.microsoft.com/download).

### Publish

```
dotnet publish -c Release -o /your/path/here -r [win10-x64/osx-x64/linux-x64] --sc
```
