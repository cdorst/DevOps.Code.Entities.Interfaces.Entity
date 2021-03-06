# DevOps.Code.Entities.Interfaces.Entity

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-interfaces-entity.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-code-entities-interfaces-entity)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.Interfaces.Entity.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Interfaces.Entity)

## Description

Common interface for code-generated entity types

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Code.DataAccess.Interfaces.Repository](https://github.com/CDorst/DevOps.Code.DataAccess.Interfaces.Repository) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-dataaccess-interfaces-repository.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-dataaccess-interfaces-repository) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.DataAccess.Interfaces.Repository.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Interfaces.Repository)
[DevOps.Code.Entities.Interfaces.StaticEntity](https://github.com/CDorst/DevOps.Code.Entities.Interfaces.StaticEntity) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-interfaces-staticentity.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-interfaces-staticentity) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.Interfaces.StaticEntity.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Interfaces.StaticEntity)
[Entities.FooBars](https://github.com/CDorst/Entities.FooBars) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/entities-foobars.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/entities-foobars) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Entities.FooBars.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Entities.FooBars)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Interfaces.Entity](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Interfaces.Entity)

## Version

1.0.5

## Metaproject

DevOps.Code.Entities.Interfaces.Entity is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

