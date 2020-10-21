namespace RobustErrorHandler.Core
{
    public abstract partial class Success<T>
    {

        public sealed class MutipleChoices : Success<T>
        {
            public MutipleChoices(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class MovedPermanently : Success<T>
        {
            public MovedPermanently(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Found : Success<T>
        {
            public Found(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class SeeOther: Success<T>
        {
            public SeeOther(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NotModified : Success<T>
        {
            public NotModified(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class UseProxy : Success<T>
        {
            public UseProxy(T value) : base(value) { }


        public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class TemporaryRedirect : Success<T>
        {
            public TemporaryRedirect(T value) : base(value) { }

        public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PermanentRedirect : Success<T>
        {
            public PermanentRedirect(T value) : base(value) { }

        public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
