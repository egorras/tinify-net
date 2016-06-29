[![Windows build Status](https://ci.appveyor.com/api/projects/status/github/raskhodchikov/tinify-net?retina=true&svg=true)](https://ci.appveyor.com/project/raskhodchikov/tinify-net)
[![NuGet](https://img.shields.io/nuget/v/TinifyApiClient.svg)](https://www.nuget.org/packages/TinifyApiClient/)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000)](https://github.com/raskhodchikov/tinify-net/blob/master/LICENSE)
# Tinify API client for .NET
.NET client for the Tinify API, used for [TinyPNG](https://tinypng.com) and [TinyJPG](https://tinyjpg.com).
#Installation
Install the API client via NuGet:
```
PM> Install-Package TinifyApiClient
```
#Usage
Compressing image
``` C#
var tinifyClient = new TinifyClient("<api_key>");
var shrinkRequest = new ShrinkRequest("<image_url>");
ShrinkResponse shrinkResponse = await tinifyClient.ShrinkAsync(shrinkRequest);
```
