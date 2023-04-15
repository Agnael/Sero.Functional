namespace Sero.Functional;

public interface IMaybe
{
   bool IsSome { get; }
   bool IsNone { get; }
}

public interface IMaybe<TValue> : IMaybe
{
   TValue Value { get; }
}