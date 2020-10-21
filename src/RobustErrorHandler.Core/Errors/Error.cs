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
    public abstract partial class Error
    {
        public IErrorMessage Message { get; private set; }

        private Error() { }

        public abstract TResult Accept<TVisitor, TResult>(TVisitor visitor)
            where TVisitor : IErrorVisitor<TResult>;

        public interface IErrorVisitor<out TVisitResult>
        {

            #region HTTPSTATUS 4XX ERRORS
            // Error 400 BadRequest
            TVisitResult Visit(Invalid result);
            TVisitResult Visit(Unauthorized result);
            TVisitResult Visit(PaymentRequired result);
            TVisitResult Visit(Forbidden result);
            TVisitResult Visit(NotFound result);
            TVisitResult Visit(MethodNotAllowed result);
            TVisitResult Visit(NotAcceptable result);
            TVisitResult Visit(ProxyAuthenticationRequired result);
            TVisitResult Visit(RequestTimeOut result);
            TVisitResult Visit(Conflict result);
            TVisitResult Visit(Gone result);
            TVisitResult Visit(LengthRequired result);
            TVisitResult Visit(PreConditionFailed result);
            TVisitResult Visit(PayloadTooLarge result);
            TVisitResult Visit(RequestURITooLong result);
            TVisitResult Visit(UnsupportedMediaType result);
            TVisitResult Visit(RequestedRangeNotSatisfiable result);
            TVisitResult Visit(ExpectationFailed result);
            TVisitResult Visit(ImATeaPot result);
            TVisitResult Visit(MisdirectedRequest result);
            TVisitResult Visit(UnProcessableEntity result);
            TVisitResult Visit(Locked result);
            TVisitResult Visit(FailedDependency result);
            TVisitResult Visit(UpgradeRequired result);
            TVisitResult Visit(PreConditionRequired result);
            TVisitResult Visit(TooManyRequest result);
            TVisitResult Visit(RequestHeaderFieldsTooLarge result);
            TVisitResult Visit(UnavailableForLegalReasons result);

            #endregion

            #region HTTPSTATUS 5XX ERRORS
            TVisitResult Visit(InternalServerError result);
            TVisitResult Visit(NotImplemented result);
            TVisitResult Visit(BadGateway result);
            TVisitResult Visit(ServiceUnavailable result);
            TVisitResult Visit(GatewayTimeout result);
            TVisitResult Visit(HttpVersionNotSupported result);
            TVisitResult Visit(VariantAlsoNegotiates result);
            TVisitResult Visit(InsufficientStorage result);
            TVisitResult Visit(LoopDetected result);
            TVisitResult Visit(NotExtended result);
            TVisitResult Visit(NetworkAuthenticationRequired result);
            TVisitResult Visit(NetworkConnectionTimeoutError result);


            #endregion

        }
    }
}