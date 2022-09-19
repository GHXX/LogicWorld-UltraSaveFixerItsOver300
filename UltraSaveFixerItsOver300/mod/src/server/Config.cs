namespace GHXX_UltraSaveFixerItsOver300.Server
{
    static class Config
    {
        /// <summary>
        /// The new maximum savetime interval.
        /// </summary>
        public const int NewMaxAllowedSaveTimeMs = 150_000; // default autosave time is 300s, so lets start out with 150s
    }
}
