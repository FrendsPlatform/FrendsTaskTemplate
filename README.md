# Frends Task Template

![](https://github.com/FrendsPlatform/FrendsTasksTemplate/workflows/AutoBuildMAster/badge.svg) ![NuGet](https://img.shields.io/nuget/v/frendstask) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This template can be used to create new Official Tasks for [Frends](frends.com) integration platform. This enables you to start writing code without any hassle with project formats etc.

The created C# solution will use the new tool chain (dotnet new etc.) from .NET Core SDK to ensure cross-platform compatibility. 

You can learn more about custom Tasks [here](https://docs.frends.com/en/articles/2206746-custom-tasks).

## Prerequisite

This template is based on .NET Core CLI tools, so you need to have .NET Core 2.1 SDK or newer. As it is having reaching end of support in 2021-08-21 it is preferably to use [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

Frends tasks are mainly coded in C#, so you will also need a developing environment for it. Visual Studio, Visual Studio Code, and Rider the most widely used ones, but any text editor will do as you can compile from [console](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build). If you are using Visual Studio you can also use, to develop frends Task, old Non-SDK style project files, and MSBuild and nuget.exe technologies. This way you would not need .NET Core 2.1 SDK, but then you are not able to create cross-platform tasks, and creating that kind of C# projects is not supported by this template. 

Unfortunately, Visual Studio or other IDEs do not currently support dotnet new templates, so you need to use the command line to install the template and create new Tasks based on it.

## Clone repository

First you need to clone the repository for the new Task. After cloning move to that folder.

## Install the template

You can install the template by following the command.

`dotnet new -i frendstasktemplate --nuget-source https://pkgs.dev.azure.com/frends-platform/frends-tasks/_packaging/main/nuget/v3/index.json` 

## Create a new custom task

You can create a new Task by the following command.

`dotnet new frendstasktemplate --name namespaceForTask --className classNameForTask --taskName TaskName --workflows TaskName`

## Move workflows 

Move workflows from the Task's folder to the .github directory inside the main directory.

e.g.

--> Frends.Echo/.github/workflows/

## Get help using the template

`dotnet new frendstasktemplate -h`

Example output:

```
Usage: new [options]

Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --nuget-source      Specifies a NuGet source to use during install.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --dry-run           Displays a summary of what would happen if the given command line were run if it would result in a template creation.
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Filters templates based on language and specifies the language of the template to create.
  --update-check      Check the currently installed template packs for updates.
  --update-apply      Check the currently installed template packs for update, and install the updates.


Official Task template (C#)
Author: Frends
Options:
  -t|--taskName
                            string - Optional
                            Default: Task

  -c|--className
                            string - Optional
                            Default: Template

  -au|--authors
                            string - Optional
                            Default: Frends

  -li|--license
                            string - Optional
                            Default: MIT

```

## Update the template

`dotnet new frendstasktemplate --update-apply `

## Uninstall the template

`dotnet new -u frendstasktemplate`

## Building this repository

`dotnet pack`

This command will build the project and create a NuGet package in .\bin\Debug 

To install this template from locally created NuGet package use

`dotnet new -i <ABSOLUTE_PATH_TO_NUPKG_FILE>`


## Special notes about this repository

URL https://github.com/FrendsPlatform/FrendsTaskTemplate  redirects here 

