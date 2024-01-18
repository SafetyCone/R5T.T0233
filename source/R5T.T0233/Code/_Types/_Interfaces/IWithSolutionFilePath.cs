using System;

using R5T.T0142;


namespace R5T.T0233
{
    /// <summary>
    /// With a strongly-typed (<see cref="ISolutionFilePath"/>) Visual Studio solution file path.
    /// </summary>
    [DataTypeMarker]
    public interface IWithSolutionFilePath
        : IHasSolutionFilePath
    {
        new ISolutionFilePath SolutionFilePath { get; set; }
    }
}
