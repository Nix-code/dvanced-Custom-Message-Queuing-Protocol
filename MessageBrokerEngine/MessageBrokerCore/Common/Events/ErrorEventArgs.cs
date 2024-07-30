namespace MessageBrokerEngine.MessageBrokerCore.Common.Events
{
    using System;

    public class ErrorEventArgs : EventArgs
    {
        public Exception Exception { get; set; }
        public string ErrorMessage { get; set; }

        public ErrorEventArgs(Exception exception, string errorMessage)
        {
            Exception = exception;
            ErrorMessage = errorMessage;
        }
    }
}
