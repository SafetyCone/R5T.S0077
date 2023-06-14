using System;


namespace R5T.S0077
{
    public class VisualStudioInstanceQueryOptionsDemonstrations : IVisualStudioInstanceQueryOptionsDemonstrations
    {
        #region Infrastructure

        public static IVisualStudioInstanceQueryOptionsDemonstrations Instance { get; } = new VisualStudioInstanceQueryOptionsDemonstrations();


        private VisualStudioInstanceQueryOptionsDemonstrations()
        {
        }

        #endregion
    }
}
