test:
	mono ".nuget/NuGet.exe" Restore "src"
	xbuild "./src/SharpRaven.sln"
	mono "./src/packages/NUnit.Runners.2.6.3/tools/nunit-console.exe" "./src/tests/SharpRaven.UnitTests/bin/Debug/SharpRaven.UnitTests.dll" -exclude=NuGet,NoMono -noxml -nodots