using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0233
{
    /// <inheritdoc cref="IVisualStudioProjectFilePath"/>
    [StrongTypeImplementationMarker]
    public class VisualStudioProjectFilePath : TypedBase<string>, IStrongTypeMarker,
        IVisualStudioProjectFilePath
    {
        public VisualStudioProjectFilePath(string value)
            : base(value)
        {
        }
    }
}