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

namespace RobustErrorHandler.Core
{
    //NOTE: HTTP Resources details from https://httpstatuses.com/
    public static class Result
    {

        #region HTTP 2xx SUCCESS
        public static Either<Error, TValue> Success<TValue>(TValue value)
            => Either.Right<Error, TValue>(value);

        public static Either<Error, Success<TValue>> Ok<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Ok(value));

        public static Either<Error, Success<TValue>> Created<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.Created(value));

        public static Either<Error, Success<TValue>> NoContent<TValue>(TValue value)
            => Either.Right<Error, Success<TValue>>(new Success<TValue>.NoContent(value));

        #endregion

        #region HTTP 4xx ERRORS

        public static Either<Error, TValue> Invalid<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Invalid(message));

        public static Either<Error, TValue> Invalid<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.Invalid(new DefaultMessage(message)));

        public static Either<Error, TValue> Unauthorized<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Unauthorized(message));

        public static Either<Error, TValue> Unauthorized<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.Unauthorized(new DefaultMessage(message)));

        public static Either<Error, TValue> Forbidden<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Forbidden(message));

        public static Either<Error, TValue> Forbidden<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.Forbidden(new DefaultMessage(message)));

        public static Either<Error, TValue> NotFound<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NotFound(message)); 
        public static Either<Error, TValue> NotFound<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.NotFound(new DefaultMessage(message)));

        public static Either<Error, TValue> Conflict<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Conflict(message));
        public static Either<Error, TValue> Conflict<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.Conflict(new DefaultMessage(message)));

        #endregion

        #region HTTP 5xx ERRORS

        public static Either<Error, TValue> InternalServerError<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.InternalServerError(message));

        public static Either<Error, TValue> InternalServerError<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.InternalServerError(new DefaultMessage(message)));

        public static Either<Error, TValue> BadGateway<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.BadGateway(message));

        public static Either<Error, TValue> BadGateway<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.BadGateway(new DefaultMessage(message)));

        public static Either<Error, TValue> ServiceUnavailable<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.ServiceUnavailable(message));

        public static Either<Error, TValue> ServiceUnavailable<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.ServiceUnavailable(new DefaultMessage(message)));

        public static Either<Error, TValue> GatewayTimeout<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.GatewayTimeout(message));

        public static Either<Error, TValue> GatewayTimeout<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.GatewayTimeout(new DefaultMessage(message)));

        public static Either<Error, TValue> HttpVersionNotSupported<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.HttpVersionNotSupported(message));

        public static Either<Error, TValue> HttpVersionNotSupported<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.HttpVersionNotSupported(new DefaultMessage(message)));

        public static Either<Error, TValue> NetworkConnectionTimeoutError<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NetworkConnectionTimeoutError(message));

        public static Either<Error, TValue> NetworkConnectionTimeoutError<TValue>(string message)
            => Either.Left<Error, TValue>(new Error.NetworkConnectionTimeoutError(new DefaultMessage(message)));

        #endregion
    }
}