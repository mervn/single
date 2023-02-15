using System;


namespace Meg.Delta.Collections
{
	public static class KeyValueYield
	{
		public static KeyValueYield<TKey, TValue> Create<TKey, TValue>
		(
			TKey key,
			(TValue, bool) value,
			Action<TKey, TValue> process
		)
		{
			return new KeyValueYield<TKey, TValue>(key, value, process);
		}
	}
}