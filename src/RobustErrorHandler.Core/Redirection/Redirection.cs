using System;
using System.Collections.Generic;
using System.Text;

namespace RobustErrorHandler.Core.SuccessCollection
{
    public abstract partial class Success<TValue>
    {

        public sealed class MutipleChoices : Success<TValue>
        {
            public MutipleChoices(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class MovedPermanently : Success<TValue>
        {
            public MovedPermanently(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Found : Success<TValue>
        {
            public Found(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class SeeOther: Success<TValue>
        {
            public SeeOther(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NotModified : Success<TValue>
        {
            public NotModified(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class UseProxy : Success<TValue>
        {
            public UseProxy(TValue value)
            {
                this.Value = value;
            }


            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class TemporaryRedirect : Success<TValue>
        {
            public TemporaryRedirect(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PermanentRedirect : Success<TValue>
        {
            public PermanentRedirect(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
