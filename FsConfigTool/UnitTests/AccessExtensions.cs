namespace UnitTests
{
    /// <summary>
    /// Unit-test only class to allow access to non-public methods.
    /// </summary>
    static class AccessExtensions
    {
        public static object CallHiddenMethod(this object o, string methodName, params object[] args)
        {
            var mi = o.GetType().GetMethod(methodName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (mi != null)
            {
                return mi.Invoke(o, args);
            }
            return null;
        }
    }
}
