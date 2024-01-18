using System;

using R5T.T0132;


namespace R5T.T0233.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IProjectFilePath"/>
        public IProjectFilePath ToProjectFilePath(string value)
        {
            var output = new ProjectFilePath(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionFilePath"/>
        public ISolutionFilePath ToSolutionFilePath(string value)
        {
            var output = new SolutionFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IVisualStudioProjectFilePath"/>
        public IVisualStudioProjectFilePath ToVisualStudioProjectFilePath(string value)
        {
            var output = new VisualStudioProjectFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IVisualStudioSolutionFilePath"/>
        public IVisualStudioSolutionFilePath ToVisualStudioSolutionFilePath(string value)
        {
            var output = new VisualStudioSolutionFilePath(value);
            return output;
        }
    }
}
