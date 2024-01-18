using System;

using R5T.T0233.Extensions;


namespace R5T.T0233.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToProjectFilePath(string)"/>
        public static IProjectFilePath ToProjectFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionFilePath(string)"/>
        public static ISolutionFilePath ToSolutionFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToVisualStudioProjectFilePath(string)"/>
        public static IVisualStudioProjectFilePath ToVisualStudioProjectFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToVisualStudioProjectFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToVisualStudioSolutionFilePath(string)"/>
        public static IVisualStudioSolutionFilePath ToVisualStudioSolutionFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToVisualStudioSolutionFilePath(value);
        }
    }
}
