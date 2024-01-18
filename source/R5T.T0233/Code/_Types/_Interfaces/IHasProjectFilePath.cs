using System;

using R5T.T0142;


namespace R5T.T0233
{
    /// <summary>
    /// Has a strongly-typed (<see cref="IProjectFilePath"/>) Visual Studio (MSBuild) project file path.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.NETLanguageLeftUnspecified" path="/summary"/>
    /// </remarks>
    [DataTypeMarker]
    public interface IHasProjectFilePath
    {
        IProjectFilePath ProjectFilePath { get; }
    }
}
