:: Generated by: https://github.com/openapitools/openapi-generator.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\WhatsAPI\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.12.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\JsonSubTypes.1.6.0\lib\net45\JsonSubTypes.dll bin\JsonSubTypes.dll
copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\JsonSubTypes.dll;bin\RestSharp.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\WhatsAPI.dll /recurse:src\WhatsAPI\*.cs /doc:bin\WhatsAPI.xml
