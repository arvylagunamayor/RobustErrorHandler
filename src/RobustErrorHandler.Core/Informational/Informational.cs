namespace RobustErrorHandler.Core
{
    public abstract partial class Success<T>
    {
        public sealed class Continue : Success<T>
        {
            public Continue(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class SwitchingProtocols : Success<T>
        {
            public SwitchingProtocols(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Processing : Success<T>
        {
            public Processing(T value) : base(value) { }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
