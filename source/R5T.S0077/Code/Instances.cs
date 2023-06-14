using System;


namespace R5T.S0077
{
    public static class Instances
    {
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static Z0015.IFilePaths FilePaths => Z0015.FilePaths.Instance;
        public static F0135.IMSBuildLocatorOperator MSBuildLocatorOperator => F0135.MSBuildLocatorOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static F0000.IStreamWriterOperator StreamWriterOperator => F0000.StreamWriterOperator.Instance;
        public static F0135.IVisualStudioInstanceOperator VisualStudioInstanceOperator => F0135.VisualStudioInstanceOperator.Instance;
        public static F0135.IVisualStudioInstanceQueryOptionsOperator VisualStudioInstanceQueryOptionsOperator => F0135.VisualStudioInstanceQueryOptionsOperator.Instance;
    }
}