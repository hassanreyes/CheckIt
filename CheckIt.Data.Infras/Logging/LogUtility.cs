using System;

namespace CheckIt.Data.Infras.Logging
{
    public static class LogUtility
    {

        public static string BuildExceptionMessage(this Exception ex)
        {

            Exception logException = ex;
            if (ex.InnerException != null)
                logException = ex.InnerException;

            string strErrorMsg = Environment.NewLine + "Message :" + logException.Message;

            // Source of the message
            strErrorMsg += Environment.NewLine + "Source :" + logException.Source;

            // Stack Trace of the error

            strErrorMsg += Environment.NewLine + "Stack Trace :" + logException.StackTrace;

            // Method where the error occurred
            strErrorMsg += Environment.NewLine + "TargetSite :" + logException.TargetSite;
            return strErrorMsg;
        }
    }
}
