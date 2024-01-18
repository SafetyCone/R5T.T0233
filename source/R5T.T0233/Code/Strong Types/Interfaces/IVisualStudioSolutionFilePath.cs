using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0233
{
    /// <summary>
    /// Strongly-types a string as a Visual Studio solution file path.
    /// </summary>
    [StrongTypeMarker]
    public interface IVisualStudioSolutionFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}