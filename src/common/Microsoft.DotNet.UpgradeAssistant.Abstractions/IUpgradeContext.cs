﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace Microsoft.DotNet.UpgradeAssistant
{
    public interface IUpgradeContext : IDisposable
    {
        string InputPath { get; }

        bool IsComplete { get; set; }

        IEnumerable<IProject> EntryPoints { get; set; }

        IProject? CurrentProject { get; }

        void SetCurrentProject(IProject? project);

        IEnumerable<IProject> Projects { get; }

        bool InputIsSolution { get; }

        bool UpdateSolution(Solution updatedSolution);

        IDictionary<string, string> GlobalProperties { get; }

        ValueTask ReloadWorkspaceAsync(CancellationToken token);
    }
}
