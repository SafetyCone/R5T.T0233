using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0233
{
    /// <inheritdoc cref="ISolutionFilePath"/>
    [StrongTypeImplementationMarker]
    public class SolutionFilePath : TypedBase<string>, IStrongTypeMarker,
        ISolutionFilePath
    {
        public SolutionFilePath(string value)
            : base(value)
        {
        }
    }
}