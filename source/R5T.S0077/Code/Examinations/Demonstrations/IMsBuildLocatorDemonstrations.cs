using System;
using System.Linq;

using R5T.T0141;


namespace R5T.S0077
{
    [DemonstrationsMarker]
    public partial interface IMsBuildLocatorDemonstrations : IDemonstrationsMarker
    {
        public void Find_VisualStudioInstances()
        {
            /// Inputs.
            var options =
                //Instances.VisualStudioInstanceQueryOptionsOperator.Get_Default()
                // Since this is an SDK-style project, only SDK MSBuilds will be found. Thus adding all the other options has no effect.
                Instances.VisualStudioInstanceQueryOptionsOperator.Get_All()
                ;
            var outputFilePath = Instances.FilePaths.OutputTextFilePath;


            /// Run.
            var visualStudioInstances = Instances.MSBuildLocatorOperator.Find_VisualStudioInstances(options);

            using (var writer = Instances.FileOperator.Get_Writer(outputFilePath))
            {
                Instances.VisualStudioInstanceOperator.Describe_To(
                    visualStudioInstances.OrderByDescending(x => x.Version),
                    writer);
            }

            Instances.NotepadPlusPlusOperator.Open(outputFilePath);
        }
    }
}
