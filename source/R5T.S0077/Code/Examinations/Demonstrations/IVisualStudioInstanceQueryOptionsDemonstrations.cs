using System;

using R5T.T0141;


namespace R5T.S0077
{
    [DemonstrationsMarker]
    public partial interface IVisualStudioInstanceQueryOptionsDemonstrations : IDemonstrationsMarker
    {
        public void Describe_Default()
        {
            var defaultOptions = Instances.VisualStudioInstanceQueryOptionsOperator.Get_Default();

            Instances.VisualStudioInstanceQueryOptionsOperator.Describe_To(
                defaultOptions,
                Console.Out);
        }
    }
}
