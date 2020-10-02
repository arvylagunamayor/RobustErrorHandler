/*
MIT License

Copyright (c) 2018 Coding Militia: ASP.NET Core - From 0 to overkill

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using RobustErrorHandler.Core.Errors;
using RobustErrorHandler.Core.SuccessCollection;

namespace RobustErrorHandler.Core
{
    //NOTE: HTTP Resources details from https://httpstatuses.com/
    public static class Result
    {
        #region HTTP 1xx INFORMATIONAL

        public static Either<Error, Success<TValue>> Continue<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Continue(value));

        public static Either<Error, Success<TValue>> SwitchingProtocols<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.SwitchingProtocols(value));

        public static Either<Error, Success<TValue>> Processing<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Processing(value));

        #endregion

        #region HTTP 2xx SUCCESS
        public static Either<Error, Success<TValue>> Success<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Ok(value));

        public static Either<Error, Success<TValue>> Created<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Created(value));

        public static Either<Error, Success<TValue>> Accepted<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Accepted(value));

        public static Either<Error, Success<TValue>> NonAuthoritativeInformation<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.NonAuthoritativeInformation(value));

        public static Either<Error, Success<TValue>> NoContent<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.NoContent(value));

        public static Either<Error, Success<TValue>> ResetContent<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.ResetContent(value));

        public static Either<Error, Success<TValue>> PartialContent<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.PartialContent(value));

        public static Either<Error, Success<TValue>> MultiStatus<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.MultiStatus(value));

        public static Either<Error, Success<TValue>> AlreadyReported<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.AlreadyReported(value));

        public static Either<Error, Success<TValue>> ImUsed<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.ImUsed(value));

        #endregion

        #region HTTP 3xx REDIRECTION
        public static Either<Error, Success<TValue>> MutipleChoices<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.MutipleChoices(value));

        public static Either<Error, Success<TValue>> MovedPermanently<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.MovedPermanently(value));

        public static Either<Error, Success<TValue>> Found<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Found(value));

        public static Either<Error, Success<TValue>> SeeOther<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.SeeOther(value));

        public static Either<Error, Success<TValue>> NotModified<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.NotModified(value));

        public static Either<Error, Success<TValue>> UseProxy<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.UseProxy(value));

        public static Either<Error, Success<TValue>> TemporaryRedirect<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.TemporaryRedirect(value));

        public static Either<Error, Success<TValue>> PermanentRedirect<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.PermanentRedirect(value));

        #endregion

        #region HTTP 4xx ERRORS

        public static Either<Error, TValue> Invalid<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Invalid(message));

        public static Either<Error, TValue> Unauthorized<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Unauthorized(message));

        public static Either<Error, TValue> PaymentRequired<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.PaymentRequired(message));

        public static Either<Error, TValue> Forbidden<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Forbidden(message));

        public static Either<Error, TValue> NotFound<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NotFound(message));

        public static Either<Error, TValue> MethodNotAllowed<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.MethodNotAllowed(message));

        public static Either<Error, TValue> NotAcceptable<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NotAcceptable(message));

        public static Either<Error, TValue> ProxyAuthenticationRequired<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.ProxyAuthenticationRequired(message));

        public static Either<Error, TValue> RequestTimeOut<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.RequestTimeOut(message));

        public static Either<Error, TValue> Conflict<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Conflict(message));

        public static Either<Error, TValue> Gone<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Gone(message));

        public static Either<Error, TValue> LengthRequired<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.LengthRequired(message));

        public static Either<Error, TValue> PreConditionFailed<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.PreConditionFailed(message));

        public static Either<Error, TValue> PayloadTooLarge<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.PayloadTooLarge(message));

        public static Either<Error, TValue> RequestURITooLong<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.RequestURITooLong(message));

        public static Either<Error, TValue> UnsupportedMediaType<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.UnsupportedMediaType(message));

        public static Either<Error, TValue> RequestedRangeNotSatisfiable<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.RequestedRangeNotSatisfiable(message));

        public static Either<Error, TValue> ExpectationFailed<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.ExpectationFailed(message));

        public static Either<Error, TValue> ImATeaPot<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.ImATeaPot(message));

        public static Either<Error, TValue> MisdirectedRequest<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.MisdirectedRequest(message));

        public static Either<Error, TValue> UnProcessableEntity<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.UnProcessableEntity(message));

        public static Either<Error, TValue> Locked<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Locked(message));

        public static Either<Error, TValue> FailedDependency<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.FailedDependency(message));

        public static Either<Error, TValue> UpgradeRequired<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.UpgradeRequired(message));

        public static Either<Error, TValue> PreConditionRequired<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.PreConditionRequired(message));

        public static Either<Error, TValue> TooManyRequest<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.TooManyRequest(message));

        public static Either<Error, TValue> RequestHeaderFieldsTooLarge<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.RequestHeaderFieldsTooLarge(message));

        public static Either<Error, TValue> UnavailableForLegalReasons<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.UnavailableForLegalReasons(message));

        #endregion

        #region HTTP 5xx ERRORS

        public static Either<Error, TValue> InternalServerError<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.InternalServerError(message));

        public static Either<Error, TValue> NotImplemented<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NotImplemented(message));

        public static Either<Error, TValue> BadGateway<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.BadGateway(message));

        public static Either<Error, TValue> ServiceUnavailable<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.ServiceUnavailable(message));

        public static Either<Error, TValue> GatewayTimeout<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.GatewayTimeout(message));

        public static Either<Error, TValue> HttpVersionNotSupported<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.HttpVersionNotSupported(message));

        public static Either<Error, TValue> VariantAlsoNegotiates<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.VariantAlsoNegotiates(message));

        public static Either<Error, TValue> InsufficientStorage<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.InsufficientStorage(message));

        public static Either<Error, TValue> LoopDetected<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.LoopDetected(message));

        public static Either<Error, TValue> NotExtended<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NotExtended(message));

        public static Either<Error, TValue> NetworkAuthenticationRequired<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NetworkAuthenticationRequired(message));

        public static Either<Error, TValue> NetworkConnectionTimeoutError<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NetworkConnectionTimeoutError(message));

        #endregion
    }
}