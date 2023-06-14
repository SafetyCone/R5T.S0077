using System;


namespace R5T.S0077
{
    public class MsBuildLocatorDemonstrations : IMsBuildLocatorDemonstrations
    {
        #region Infrastructure

        public static IMsBuildLocatorDemonstrations Instance { get; } = new MsBuildLocatorDemonstrations();


        private MsBuildLocatorDemonstrations()
        {
        }

        #endregion
    }
}
