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
    public static class OptionalExtensions
    {
        public static Optional<TOut> Map<TIn, TOut>(this Optional<TIn> maybeValue, Func<TIn, TOut> mapper)
        {
            Ensure.NotNull(mapper, nameof(mapper));

            return maybeValue.TryGetValue(out var value)
                ? Optional.Some(mapper(value))
                : Optional.None<TOut>();
        }

        public static T ValueOr<T>(this Optional<T> maybeValue, Func<T> alternativeFactory)
        {
            Ensure.NotNull(alternativeFactory, nameof(alternativeFactory));

            return maybeValue.TryGetValue(out var value)
                ? value
                : alternativeFactory();
        }

        public static TOut MapValueOr<TIn, TOut>(this Optional<TIn> maybeValue, Func<TIn, TOut> some, Func<TOut> none)
        {
            Ensure.NotNull(some, nameof(some));
            Ensure.NotNull(none, nameof(none));

            return maybeValue.TryGetValue(out var value)
                ? some(value)
                : none();
        }

        public static void Match<T>(this Optional<T> maybeValue, Action<T> some, Action none)
        {
            Ensure.NotNull(some, nameof(some));
            Ensure.NotNull(none, nameof(none));

            if (maybeValue.TryGetValue(out var value))
                some(value);
            else
                none();
        }

        public static void MatchSome<T>(this Optional<T> maybeValue, Action<T> some)
        {
            Ensure.NotNull(some, nameof(some));

            if (maybeValue.TryGetValue(out var value))
            {
                some(value);
            }
        }

        public static async Task MatchSomeAsync<T>(this Optional<T> maybeValue, Func<T, Task> some)
        {
            Ensure.NotNull(some, nameof(some));

            if (maybeValue.TryGetValue(out var value))
            {
                await some(value);
            }
        }

        public static void MatchNone<T>(this Optional<T> maybeValue, Action none)
        {
            Ensure.NotNull(none, nameof(none));

            if (!maybeValue.TryGetValue(out _))
            {
                none();
            }
        }

        public static async Task MatchNoneAsync<T>(this Optional<T> maybeValue, Func<Task> none)
        {
            Ensure.NotNull(none, nameof(none));

            if (!maybeValue.TryGetValue(out _))
            {
                await none();
            }
        }
    }
}