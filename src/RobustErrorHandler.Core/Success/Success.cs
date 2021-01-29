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
            #region HTTP STATUSES SUCCESS

            TVisitResult Visit(Ok result);
            TVisitResult Visit(Created result);
            TVisitResult Visit(NoContent result);

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


        public sealed class NoContent : Success<T>
        {
            public NoContent(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

    }
}
