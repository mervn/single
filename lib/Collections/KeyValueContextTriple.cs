using System;


namespace Meg.Delta.Collections
{
	public static class KeyValueContextTriple
	{
		public static KeyValueContextTriple<TKey, TValue> Create<TKey, TValue>
		(
			TKey key,
			TValue value,
			Action<TValue> context
		)
		{
			return new KeyValueContextTriple<TKey, TValue>(key, value, context);
		}
	}
}