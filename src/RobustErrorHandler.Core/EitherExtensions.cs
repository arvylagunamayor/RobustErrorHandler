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

using System;
using System.Threading.Tasks;

namespace RobustErrorHandler.Core
{
    public static class EitherExtensions
    {
        public static TOut Fold<TLeftIn, TRightIn, TOut>(
            this Either<TLeftIn, TRightIn> result,
            Func<TLeftIn, TOut> left,
            Func<TRightIn, TOut> right)
        {
            Ensure.NotNull(result, nameof(result));
            Ensure.NotNull(left, nameof(left));
            Ensure.NotNull(right, nameof(right));

            return result switch
            {
                Either<TLeftIn, TRightIn>.Left error => left(error.Value),
                Either<TLeftIn, TRightIn>.Right success => right(success.Value),
                _ => throw CreateUnexpectedResultTypeException(nameof(result))
            };
        }

        public static async Task<TOut> FoldAsync<TLeftIn, TRightIn, TOut>(
            this Either<TLeftIn, TRightIn> result,
            Func<TLeftIn, Task<TOut>> left,
            Func<TRightIn, Task<TOut>> right)
        {
            Ensure.NotNull(result, nameof(result));
            Ensure.NotNull(left, nameof(left));
            Ensure.NotNull(right, nameof(right));

            return result switch
            {
                Either<TLeftIn, TRightIn>.Left error => await left(error.Value),
                Either<TLeftIn, TRightIn>.Right success => await right(success.Value),
                _ => throw CreateUnexpectedResultTypeException(nameof(result))
            };
        }

        public static Either<TLeft, TRightOut> Map<TLeft, TRightIn, TRightOut>(
            this Either<TLeft, TRightIn> result, Func<TRightIn, TRightOut> right)
        {
            Ensure.NotNull(result, nameof(result));
            Ensure.NotNull(right, nameof(right));

            return result switch
            {
                Either<TLeft, TRightIn>.Left error => Either.Left<TLeft, TRightOut>(error.Value),
                Either<TLeft, TRightIn>.Right success => Either.Right<TLeft, TRightOut>(right(success.Value)),
                _ => throw CreateUnexpectedResultTypeException(nameof(result))
            };
        }

        public static async Task<Either<TLeft, TRightOut>> MapAsync<TLeft, TRightIn, TRightOut>(
            this Either<TLeft, TRightIn> result, Func<TRightIn, Task<TRightOut>> right)
        {
            Ensure.NotNull(result, nameof(result));
            Ensure.NotNull(right, nameof(right));

            return result switch
            {
                Either<TLeft, TRightIn>.Left error => Either.Left<TLeft, TRightOut>(error.Value),
                Either<TLeft, TRightIn>.Right success => Either.Right<TLeft, TRightOut>(await right(success.Value)),
                _ => throw CreateUnexpectedResultTypeException(nameof(result))
            };
        }

        public static Either<TLeft, TRightOut> FlatMap<TLeft, TRightIn, TRightOut>(
            this Either<TLeft, TRightIn> result, Func<TRightIn, Either<TLeft, TRightOut>> right)
        {
            Ensure.NotNull(result, nameof(result));
            Ensure.NotNull(right, nameof(right));

            return result switch
            {
                Either<TLeft, TRightIn>.Left error => Either.Left<TLeft, TRightOut>(error.Value),
                Either<TLeft, TRightIn>.Right success => right(success.Value),
                _ => throw CreateUnexpectedResultTypeException(nameof(result))
            };
        }

        public static async Task<Either<TLeft, TRightOut>> FlatMapAsync<TLeft, TRightIn, TRightOut>(
            this Either<TLeft, TRightIn> result, Func<TRightIn, Task<Either<TLeft, TRightOut>>> right)
        {
            Ensure.NotNull(result, nameof(result));
            Ensure.NotNull(right, nameof(right));

            return result switch
            {
                Either<TLeft, TRightIn>.Left error => Either.Left<TLeft, TRightOut>(error.Value),
                Either<TLeft, TRightIn>.Right success => await right(success.Value),
                _ => throw CreateUnexpectedResultTypeException(nameof(result))
            };
        }

        private static Exception CreateUnexpectedResultTypeException(string parameterName)
            => new ArgumentOutOfRangeException(
                parameterName,
                "Should never happen -> Either is always Left or Right");
    }
}