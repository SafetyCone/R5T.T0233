using System;

using R5T.T0142;


namespace R5T.T0233
{
    /// <summary>
    /// Has a strongly-typed (<see cref="ISolutionFilePath"/>) Visual Studio solution file path.
    /// </summary>
    [DataTypeMarker]
    public interface IHasSolutionFilePath
    {
        ISolutionFilePath SolutionFilePath { get; }
    }
}
