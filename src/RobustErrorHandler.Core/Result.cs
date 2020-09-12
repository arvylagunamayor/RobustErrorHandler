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
    public static class Result
    {
        public static Either<Error, TValue> Success<TValue>(TValue value)
            => Either.Right<Error, TValue>(value);
        
        public static Either<Error, TValue> Invalid<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Invalid(message));

        public static Either<Error, TValue> NotFound<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.NotFound(message));

        public static Either<Error, TValue> Unauthorized<TValue>(IErrorMessage message)
            => Either.Left<Error, TValue>(new Error.Unauthorized(message));
    }
}