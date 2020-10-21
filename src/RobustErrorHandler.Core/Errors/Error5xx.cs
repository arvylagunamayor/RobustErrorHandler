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

        public sealed class NotImplemented : Error
        {
            public NotImplemented(IErrorMessage message)
            {
                Message = message;
            }
            public NotImplemented(string errorMessage)
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

        public sealed class VariantAlsoNegotiates : Error
        {
            public VariantAlsoNegotiates(IErrorMessage message)
            {
                Message = message;
            }
            public VariantAlsoNegotiates(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class InsufficientStorage : Error
        {
            public InsufficientStorage(IErrorMessage message)
            {
                Message = message;
            }
            public InsufficientStorage(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class LoopDetected : Error
        {
            public LoopDetected(IErrorMessage message)
            {
                Message = message;
            }
            public LoopDetected(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NotExtended : Error
        {
            public NotExtended(IErrorMessage message)
            {
                Message = message;
            }
            public NotExtended(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NetworkAuthenticationRequired : Error
        {
            public NetworkAuthenticationRequired(IErrorMessage message)
            {
                Message = message;
            }
            public NetworkAuthenticationRequired(string errorMessage)
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
