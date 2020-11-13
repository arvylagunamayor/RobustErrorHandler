namespace RobustErrorHandler.Core
{
    //NOTE: HTTP Resources details from https://httpstatuses.com/
    public abstract partial class Error
    {

        public sealed class InternalServerError : Error
        {
            public InternalServerError(IErrorMessage message)
            {
                Message = message;
            }
            public InternalServerError(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }


        public sealed class BadGateway : Error
        {
            public BadGateway(IErrorMessage message)
            {
                Message = message;
            }
            public BadGateway(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ServiceUnavailable : Error
        {
            public ServiceUnavailable(IErrorMessage message)
            {
                Message = message;
            }
            public ServiceUnavailable(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class GatewayTimeout : Error
        {
            public GatewayTimeout(IErrorMessage message)
            {
                Message = message;
            }
            public GatewayTimeout(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class HttpVersionNotSupported : Error
        {
            public HttpVersionNotSupported(IErrorMessage message)
            {
                Message = message;
            }
            public HttpVersionNotSupported(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NetworkConnectionTimeoutError : Error
        {
            public NetworkConnectionTimeoutError(IErrorMessage message)
            {
                Message = message;
            }
            public NetworkConnectionTimeoutError(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
