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
}
