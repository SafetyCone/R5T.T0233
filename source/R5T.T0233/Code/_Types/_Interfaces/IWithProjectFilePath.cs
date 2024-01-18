using System;

using R5T.T0142;


namespace R5T.T0233
{
    /// <summary>
    /// With a strongly-typed (<see cref="IProjectFilePath"/>) Visual Studio (MSBuild) project file path.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.NETLanguageLeftUnspecified" path="/summary"/>
    /// </remarks>
    [DataTypeMarker]
    public interface IWithProjectFilePath :
        IHasProjectFilePath
    {
        new IProjectFilePath ProjectFilePath { get; set; }
    }
}
