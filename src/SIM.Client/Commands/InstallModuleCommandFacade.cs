﻿namespace SIM.Client.Commands
{
  using CommandLine;
  using JetBrains.Annotations;
  using SIM.Core.Commands;

  public class InstallModuleCommandFacade : InstallModuleCommand
  {
    [UsedImplicitly]
    public InstallModuleCommandFacade()
    {
    }

    [Option('n', "name", Required = true)]
    public override string Name { get; set; }

    [Option('m', "module")]
    public override string Module { get; set; }

    [Option('v', "version")]
    public override string Version { get; set; }

    [Option('r', "revision")]
    public override string Revision { get; set; }
  }
}