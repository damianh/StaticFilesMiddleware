// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Owin;
using Microsoft.Owin.StaticFiles;

namespace Owin
{
    /// <summary>
    /// Extension methods that combine all of the static file middleware components:
    /// Default files, directory browsing, send file, and static files
    /// </summary>
    public static class FileServerExtensions
    {
        /// <summary>
        /// Enable all static file middleware (except directory browsing) for the current request path in the current directory.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IAppBuilder UseFileServer(this IAppBuilder builder)
        {
            return UseFileServer(builder, new FileServerOptions());
        }

        /// <summary>
        /// Enables all static file middleware (except directory browsing) for the given request path from the directory of the same name
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="requestPath">The relative request path and physical path.</param>
        /// <returns></returns>
        public static IAppBuilder UseFileServer(this IAppBuilder builder, string requestPath)
        {
            return UseFileServer(builder, new FileServerOptions() { RequestPath = new PathString(requestPath) });
        }

        /// <summary>
        /// Enable all static file middleware with the given options
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IAppBuilder UseFileServer(this IAppBuilder builder, FileServerOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            if (options.EnableDefaultFiles)
            {
                builder = builder.UseDefaultFiles(options.DefaultFilesOptions);
            }

            return builder
                .UseSendFileFallback()
                .UseStaticFiles(options.StaticFileOptions);
        }
    }
}
