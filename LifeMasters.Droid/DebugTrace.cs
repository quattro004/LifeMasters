using System;
using MvvmCross.Platform.Platform;

namespace LifeMasters.Droid
{
    public class DebugTrace : IMvxTrace
    {
        public void Trace(MvxTraceLevel level, string tag, string message)
        {
            throw new NotImplementedException();
        }

        public void Trace(MvxTraceLevel level, string tag, Func<string> message)
        {
            throw new NotImplementedException();
        }

        public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}