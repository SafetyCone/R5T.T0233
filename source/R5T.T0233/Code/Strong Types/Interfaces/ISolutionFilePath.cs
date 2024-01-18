using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0233
{
    /// <inheritdoc cref="IVisualStudioSolutionFilePath"/>
    [StrongTypeMarker]
    public interface ISolutionFilePath : IStrongTypeMarker,
        // Even though this project should only contain *root* strong-types,
        // this is just an aliasing of a root strong type, not an actual functionality inheritance hierarchy
        // (like inheriting from IPath would be).
        IVisualStudioSolutionFilePath
    {
    }
}