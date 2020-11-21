using System;
using System.Runtime.CompilerServices;

namespace BGW.Core
{
    public class Debug
    {
        private static bool IsDebugModeEnabled = true;
        public static void CatchException(Exception ex, [CallerMemberName] string FunctionName = "")
        {
            if (!IsDebugModeEnabled) return;

        }
        public static void OutputDebugString(string Text)
        {

        }
    }
}
