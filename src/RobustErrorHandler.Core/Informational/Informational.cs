using System;
using System.Collections.Generic;
using System.Text;

namespace RobustErrorHandler.Core.SuccessCollection
{
    public abstract partial class Success<TValue>
    {
        public sealed class Continue : Success<TValue>
        {
            public Continue(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class SwitchingProtocols : Success<TValue>
        {
            public SwitchingProtocols(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Processing : Success<TValue>
        {
            public Processing(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
