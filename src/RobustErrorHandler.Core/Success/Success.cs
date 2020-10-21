namespace RobustErrorHandler.Core
{
    public abstract partial class Success<T>
    {
        public T Value { get; private set; }

        private Success(T value) { this.Value = value; }

        public abstract TResult Accept<TVisitor, TResult>(TVisitor visitor)
            where TVisitor : ISucessVisitor<TResult>;

        public interface ISucessVisitor<out TVisitResult>
        {
            #region HTTP STATUSES REDIRECTION

            TVisitResult Visit(MutipleChoices result);

            TVisitResult Visit(MovedPermanently result);

            TVisitResult Visit(Found result);

            TVisitResult Visit(SeeOther result);

            TVisitResult Visit(NotModified result);

            TVisitResult Visit(UseProxy result);

            TVisitResult Visit(TemporaryRedirect result);

            TVisitResult Visit(PermanentRedirect result);

            #endregion

            #region HTTP STATUSES SUCCESS

            TVisitResult Visit(Ok result);
            TVisitResult Visit(Created result);
            TVisitResult Visit(Accepted result);
            TVisitResult Visit(NonAuthoritativeInformation result);
            TVisitResult Visit(NoContent result);
            TVisitResult Visit(ResetContent result);
            TVisitResult Visit(PartialContent result);
            TVisitResult Visit(MultiStatus result);
            TVisitResult Visit(AlreadyReported result);
            TVisitResult Visit(ImUsed result);

            #endregion


            #region HTTP STATUSES INFORMATIONAL

            TVisitResult Visit(Continue result);

            TVisitResult Visit(SwitchingProtocols result);

            TVisitResult Visit(Processing result);

            #endregion

        }

        public sealed class Ok : Success<T>
        {
            public Ok(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Created : Success<T>
        {
            public Created(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Accepted : Success<T>
        {
            public Accepted(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NonAuthoritativeInformation : Success<T>
        {
            public NonAuthoritativeInformation(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NoContent : Success<T>
        {
            public NoContent(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ResetContent : Success<T>
        {
            public ResetContent(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PartialContent : Success<T>
        {
            public PartialContent(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class MultiStatus : Success<T>
        {
            public MultiStatus(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class AlreadyReported : Success<T>
        {
            public AlreadyReported(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ImUsed : Success<T>
        {
            public ImUsed(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
