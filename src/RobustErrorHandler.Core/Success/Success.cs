using System;
using System.Collections.Generic;
using System.Text;

namespace RobustErrorHandler.Core.SuccessCollection
{
    public abstract partial class Success<TValue>
    {
        public TValue Value { get; private set; }

        private Success() { }

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

        public sealed class Ok : Success<TValue>
        {
            public Ok(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Created : Success<TValue>
        {
            public Created(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class Accepted : Success<TValue>
        {
            public Accepted(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NonAuthoritativeInformation : Success<TValue>
        {
            public NonAuthoritativeInformation(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class NoContent : Success<TValue>
        {
            public NoContent(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ResetContent : Success<TValue>
        {
            public ResetContent(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class PartialContent : Success<TValue>
        {
            public PartialContent(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class MultiStatus : Success<TValue>
        {
            public MultiStatus(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class AlreadyReported : Success<TValue>
        {
            public AlreadyReported(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }

        public sealed class ImUsed : Success<TValue>
        {
            public ImUsed(TValue value)
            {
                this.Value = value;
            }

            public override TResult Accept<TVisitor, TResult>(TVisitor visitor)
                => visitor.Visit(this);
        }
    }
}
