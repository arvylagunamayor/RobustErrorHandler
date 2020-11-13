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

        // Error 403 Forbidden
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

    }
}
