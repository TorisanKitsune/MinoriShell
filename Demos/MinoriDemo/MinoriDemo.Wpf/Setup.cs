﻿using Microsoft.Extensions.Logging;
using MinoriEditorShell.Platforms.Wpf;

namespace MinoriDemo.WpfCore
{
    internal class Setup : MesWpfSetup<Core.App>
    {
        protected override ILoggerFactory CreateLogFactory() =>
            LoggerFactory.Create((builder) =>
                builder
                    .SetMinimumLevel(0)
                    .AddDebug());

        protected override ILoggerProvider CreateLogProvider() => null;
    }
}