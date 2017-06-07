#tool "nuget:?package=NUnit.ConsoleRunner"

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var buildDir = Directory("./Presentation.Web/bin") + Directory(configuration);
var solution = "./CompleteCakeDemo.sln";

Task("Clean")
	.Does(() => {
		CleanDirectory(buildDir);
	});

Task("Restore-NuGet-Packages")
	.IsDependentOn("Clean")
	.Does(() => {
		NuGetRestore(solution);
	});

Task("Build")
	.IsDependentOn("Restore-NuGet-Packages")
	.Does(() => {
		MSBuild(solution, settings => settings.SetConfiguration(configuration));
	});

Task("Run-Unit-Tests")
	.IsDependentOn("Build")
	.Does(() => {
		DotNetCoreTest("./Presentation.Web.Tests/Presentation.Web.Tests.csproj");
	});


Task("Default")
	.IsDependentOn("Run-Unit-Tests");

RunTarget(target);