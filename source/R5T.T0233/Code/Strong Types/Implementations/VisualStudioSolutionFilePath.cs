using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0233
{
    /// <inheritdoc cref="IVisualStudioSolutionFilePath"/>
    [StrongTypeImplementationMarker]
    public class VisualStudioSolutionFilePath : TypedBase<string>, IStrongTypeMarker,
        IVisualStudioSolutionFilePath
    {
        public VisualStudioSolutionFilePath(string value)
            : base(value)
        {
        }
    }
}