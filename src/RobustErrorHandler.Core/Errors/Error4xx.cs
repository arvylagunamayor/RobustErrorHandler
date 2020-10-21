namespace RobustErrorHandler.Core
{
    //NOTE: HTTP Resources details from https://httpstatuses.com/
    public abstract partial class Error
    {

        // Error 400 BadRequest
        public sealed class Invalid : Error
        {
            public Invalid(IErrorMessage message)
            {
                Message = message;
            }
            public Invalid(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        // Error 401 BadRequest
        public sealed class Unauthorized : Error
        {
            public Unauthorized(IErrorMessage message)
            {
                Message = message;
            }
            public Unauthorized(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        // Error 402 BadRequest
        public sealed class PaymentRequired : Error
        {
            public PaymentRequired(IErrorMessage message)
            {
                Message = message;
            }
            public PaymentRequired(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        // Error 403 BadRequest
        public sealed class Forbidden : Error
        {
            public Forbidden(IErrorMessage message)
            {
                Message = message;
            }
            public Forbidden(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        // Error 404 Not Found
        public sealed class NotFound : Error
        {
            public NotFound(IErrorMessage message)
            {
                Message = message;
            }

            public NotFound(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class MethodNotAllowed : Error
        {
            public MethodNotAllowed(IErrorMessage message)
            {
                Message = message;
            }

            public MethodNotAllowed(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NotAcceptable : Error
        {
            public NotAcceptable(IErrorMessage message)
            {
                Message = message;
            }

            public NotAcceptable(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ProxyAuthenticationRequired : Error
        {
            public ProxyAuthenticationRequired(IErrorMessage message)
            {
                Message = message;
            }

            public ProxyAuthenticationRequired(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class RequestTimeOut : Error
        {
            public RequestTimeOut(IErrorMessage message)
            {
                Message = message;
            }

            public RequestTimeOut(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Conflict : Error
        {
            public Conflict(IErrorMessage message)
            {
                Message = message;
            }

            public Conflict(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Gone : Error
        {
            public Gone(IErrorMessage message)
            {
                Message = message;
            }

            public Gone(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class LengthRequired : Error
        {
            public LengthRequired(IErrorMessage message)
            {
                Message = message;
            }

            public LengthRequired(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PreConditionFailed : Error
        {
            public PreConditionFailed(IErrorMessage message)
            {
                Message = message;
            }

            public PreConditionFailed(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PayloadTooLarge : Error
        {
            public PayloadTooLarge(IErrorMessage message)
            {
                Message = message;
            }

            public PayloadTooLarge(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class RequestURITooLong : Error
        {
            public RequestURITooLong(IErrorMessage message)
            {
                Message = message;
            }

            public RequestURITooLong(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class UnsupportedMediaType : Error
        {
            public UnsupportedMediaType(IErrorMessage message)
            {
                Message = message;
            }

            public UnsupportedMediaType(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class RequestedRangeNotSatisfiable : Error
        {
            public RequestedRangeNotSatisfiable(IErrorMessage message)
            {
                Message = message;
            }

            public RequestedRangeNotSatisfiable(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ExpectationFailed : Error
        {
            public ExpectationFailed(IErrorMessage message)
            {
                Message = message;
            }

            public ExpectationFailed(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ImATeaPot : Error
        {
            public ImATeaPot(IErrorMessage message)
            {
                Message = message;
            }

            public ImATeaPot(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class MisdirectedRequest : Error
        {
            public MisdirectedRequest(IErrorMessage message)
            {
                Message = message;
            }

            public MisdirectedRequest(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class UnProcessableEntity : Error
        {
            public UnProcessableEntity(IErrorMessage message)
            {
                Message = message;
            }

            public UnProcessableEntity(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Locked : Error
        {
            public Locked(IErrorMessage message)
            {
                Message = message;
            }

            public Locked(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class FailedDependency : Error
        {
            public FailedDependency(IErrorMessage message)
            {
                Message = message;
            }

            public FailedDependency(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class UpgradeRequired : Error
        {
            public UpgradeRequired(IErrorMessage message)
            {
                Message = message;
            }

            public UpgradeRequired(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PreConditionRequired : Error
        {
            public PreConditionRequired(IErrorMessage message)
            {
                Message = message;
            }

            public PreConditionRequired(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class TooManyRequest : Error
        {
            public TooManyRequest(IErrorMessage message)
            {
                Message = message;
            }

            public TooManyRequest(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class RequestHeaderFieldsTooLarge : Error
        {
            public RequestHeaderFieldsTooLarge(IErrorMessage message)
            {
                Message = message;
            }

            public RequestHeaderFieldsTooLarge(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class UnavailableForLegalReasons : Error
        {
            public UnavailableForLegalReasons(IErrorMessage message)
            {
                Message = message;
            }

            public UnavailableForLegalReasons(string errorMessage)
            {
                Message = new DefaultMessage(errorMessage);
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

    }
}
