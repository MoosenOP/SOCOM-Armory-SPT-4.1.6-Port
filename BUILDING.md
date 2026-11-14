# Building the SPT 4.1.6 compatibility port

This project targets **.NET 10** and **SPT 4.1.6**.

1. Install the .NET 10 SDK.
2. Place the project in a directory named `source`.
3. Create a sibling directory named `references`, containing compatible development reference assemblies from your own SPT installation and installed dependencies:
   - `SPTarkov.Common.dll`
   - `SPTarkov.DI.dll`
   - `SPTarkov.Server.Core.dll`
   - `SPTarkov.Reflection.dll`
   - `SemanticVersioning.dll`
   - `WTT-ServerCommonLib.dll`
4. From the `source` directory, run `dotnet build SOCOM.csproj -c Release`.
5. Package the compiled `SOCOM.dll` and the contents of `Resources` under `SPT_Runtime/user/mods/SOCOM/`.

**Important:** This repository is being populated from the Test 15B source archive. The complete `Resources` tree is not yet published here. Until it is added, this repository is an incomplete source snapshot and should not be treated as a fully reproducible release build.

No third-party SPT or WTT binaries are redistributed in this repository. Use compatible copies from your own installations. The compiled DLL in the tested player release has not been independently reproduced from this repository.
