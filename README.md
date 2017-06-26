# Cake

## What is Cake?

Cake (http://cakebuild.net) is a cross platform build automation system with a C# DSL.

With Cake you can do many things such as:
* Compiling code
* Copy files/folders
* Running unit tests
* Compress files
* Build NuGet packages
* and other things...

There are many _Addins_ that you can use in Cake like: 
Docker, Code Coverage, Git, MicroServices, Postman, Powershell, and many others.
You can explore these addins [here](http://cakebuild.net/addins/).

## Why Cake?

There are many advantages to use cake such as:
* Versioning build script with source code
* You can run our build in any machine with .Net framework, Our Team City, Cloud build services etc
* Write in C#
* Unify in one file our build process
* Open source
* You don't need to version binaries

I use this extension for Visual Studio Code: Cake build script language support. Unfortunately you don't have intellisence for Cake, if you find something in the future, please advice me :-)

There is a great responsive community on [Gitter chat](https://gitter.im/cake-build/cake).

## How can I start?

You just need the _build.ps1_ file present in my [demo project](https://github.com/monica85rodrigues/cake-demo/tree/master/CompleteCakeDemo) and create a new file _**name-of-file**.cake_ in same directory. Usually the name of this file is build.cake but you can use another name.

Yes, you only need this for start :blush:

Now, you are ready to start writting in your cake file all the tasks you want.

After to write all taks you just need to run build.ps1 with Powershell window or you can use Visual studio code terminal.

## Demo structure

In my demo structure you can see two projects:
* Web Api
* Web Api Tests

In cake file you can see the following tasks:
* Clean your solution
* Restore all nuget packages
* Build your solution
* Run unit tests
* Run Specflow Tests

**Note:** You have tools to run unit tests for XUnit or others. Explore it!

> Read my build.cake and try to understand it! I know, it's a very very simple example :smiley: :smiley: 

### Useful links

* [Getting started here from cake website](http://cakebuild.net/docs/tutorials/getting-started)
* [Addins](http://cakebuild.net/addins/)
* [Documentation](http://cakebuild.net/docs/)
* [Gitter chat](https://gitter.im/cake-build/cake)















