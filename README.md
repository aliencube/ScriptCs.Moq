# ScriptCs.Moq #

[![Build status](https://ci.appveyor.com/api/projects/status/if7cxf3jy0qxwswo/branch/dev?svg=true)](https://ci.appveyor.com/project/justinyoo/scriptcs-moq/branch/dev) | [![](https://img.shields.io/nuget/v/ScriptCs.Moq.svg)](https://www.nuget.org/packages/ScriptCs.Moq)

**ScriptCs.Moq** provides a script package to implement the [Moq](https://github.com/moq/moq4) library in Script CS.


## Getting Started ##

In order to use **ScriptCs.Moq** in your `.csx` file, firstly you need to download NuGet package of this script pack.


### `NuGet.Config` ###

Your `NuGet.Config` **MUST** be compatible to version 2.x; otherwise ScriptCs will be complaining to install NuGet packages. There are a few ways to sort this out.

* Update `%APPDATA%\NuGet\NuGet.Config`: This affects on all other packages globally.
* Add `scriptcs_nuget.config` under your ScriptCs folder: This only affects on your specific ScriptCs folder.

Either way, the NuGet endpoint URL for the version 2.x should be included like:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://www.nuget.org/api/v2/" />
  </packageSources>
</configuration>
```


### Installing ScriptPack ###

If your NuGet feed is ready, download **ScriptCs.Moq** into your working folder.

```
scriptcs -install ScriptCs.Moq
```


### Writing ScriptCs Code ###

Now you are ready to go. Here's a sample `run.csx` file.

```csharp
public interface IMyInterface
{
    string MyMethod();
}

var moq = Require<MoqPackContext>();

var mocked = moq.Mock<IMyInterface>();
mocked.Setup(p => p.MyMethod()).Returns("Hello World");

var result = mocked.Object.MyMethod();
Console.WriteLine(result);
```


### Running ScriptCs Code ###

Once you complete writing a code, run it on your command prompt:

```
scriptcs run.csx
```

## Contribution ##

Your contributions are always welcome! All your work should be done in your forked repository. Once you finish your work with corresponding tests, please send us a pull request onto our `dev` branch for review.


## License ##

**ScriptCs.Moq** is released under [MIT License](http://opensource.org/licenses/MIT)

> The MIT License (MIT)
>
> Copyright (c) 2016 [aliencube.org](http://aliencube.org)
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
> 
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
