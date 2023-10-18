using OneOf;

namespace Sero.Functional;

public static class OneOfAsync
{
	public static async Task<TResult> MatchAsync<T0, T1, TResult>(
		this Task<OneOf<T0, T1>> oneOfTask,
		Func<T0, TResult> f0,
		Func<T1, TResult> f1)
	{
		OneOf<T0, T1> oneOf = await oneOfTask;
		return oneOf.Match(f0, f1);
	}

	public static async Task<TResult> MatchAsync<T0, T1, T2, TResult>(
		this Task<OneOf<T0, T1, T2>> oneOfTask,
		Func<T0, TResult> f0,
		Func<T1, TResult> f1,
		Func<T2, TResult> f2)
	{
		OneOf<T0, T1, T2> oneOf = await oneOfTask;
		return oneOf.Match(f0, f1, f2);
	}

	public static async Task<TResult> MatchAsync<T0, T1, T2, T3, TResult>(
		this Task<OneOf<T0, T1, T2, T3>> oneOfTask,
		Func<T0, TResult> f0,
		Func<T1, TResult> f1,
		Func<T2, TResult> f2,
		Func<T3, TResult> f3)
	{
		OneOf<T0, T1, T2, T3> oneOf = await oneOfTask;
		return oneOf.Match(f0, f1, f2, f3);
	}
}
