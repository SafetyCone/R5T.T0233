using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0233
{
    /// <summary>
    /// Strongly-types a string as a Visual Studio (MSBuild) project file path.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.NETLanguageLeftUnspecified" path="/summary"/>
    /// </remarks>
    [StrongTypeMarker]
    public interface IVisualStudioProjectFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}