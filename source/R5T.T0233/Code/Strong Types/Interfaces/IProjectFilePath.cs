using System;

using R5T.T0178;


namespace R5T.T0233
{
    /// <inheritdoc cref="IVisualStudioProjectFilePath"/>
    [StrongTypeMarker]
    public interface IProjectFilePath : IStrongTypeMarker,
        // Even though this project should only contain *root* strong-types,
        // this is just an aliasing of a root strong type, not an actual functionality inheritance hierarchy
        // (like inheriting from IPath would be).
        IVisualStudioProjectFilePath
    {
    }
}