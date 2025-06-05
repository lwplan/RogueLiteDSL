using Pidgin;

namespace DSLApp1.Dsl
{
    public static class OptionalExtensions
    {
        public static T? ToNullable<T>(this Maybe<T> optional) where T : struct =>
            optional.HasValue ? optional.Value : (T?)null;
    }
}