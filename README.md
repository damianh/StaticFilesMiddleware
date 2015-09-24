# StaticFilesMiddleware
Fork of [Microsoft.Owin.StaticFiles](https://katanaproject.codeplex.com/) with the following changes

 - Support pre-gzipped files by checking for the presence of a `.gz` version of a resolved file.
 - Is a MidFunc
 - Does not depend on `owin.dll`
