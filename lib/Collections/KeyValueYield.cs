using System;


namespace Meg.Delta.Collections
{
	public static class KeyValueYield
	{
		public static KeyValueYield<TKey, TValue> Create<TKey, TValue>
		(
			TKey key,
			TValue value,
			Action<TValue> context
		)
		{
			return new KeyValueYield<TKey, TValue>(key, value, context);
		}
	}
}