using System;


namespace R5T.S0077
{
    public class MSBuildLocatorScripts : IMSBuildLocatorScripts
    {
        #region Infrastructure

        public static IMSBuildLocatorScripts Instance { get; } = new MSBuildLocatorScripts();


        private MSBuildLocatorScripts()
        {
        }

        #endregion
    }
}
