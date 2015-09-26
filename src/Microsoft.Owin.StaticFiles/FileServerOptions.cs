// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Owin.StaticFiles.Infrastructure;

namespace Microsoft.Owin.StaticFiles
{
    /// <summary>
    /// Options for all of the static file middleware components
    /// </summary>
    public class FileServerOptions : SharedOptionsBase<FileServerOptions>
    {
        /// <summary>
        /// Creates a combined options class for all of the static file middleware components.
        /// </summary>
        public FileServerOptions()
            : base(new SharedOptions())
        {
            StaticFileOptions = new StaticFileOptions(SharedOptions);
            DefaultFilesOptions = new DefaultFilesOptions(SharedOptions);
            EnableDefaultFiles = true;
        }

        /// <summary>
        /// Options for configuring the StaticFileMiddleware.
        /// </summary>
        public StaticFileOptions StaticFileOptions { get; private set; }

        /// <summary>
        /// Options for configuring the DefaultFilesMiddleware.
        /// </summary>
        public DefaultFilesOptions DefaultFilesOptions { get; private set; }

        /// <summary>
        /// Default files are enabled by default.
        /// </summary>
        public bool EnableDefaultFiles { get; set; }
    }
}
