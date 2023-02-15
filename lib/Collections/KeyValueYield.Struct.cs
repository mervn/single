using System;


namespace Meg.Delta.Collections
{
	[Serializable]
	public readonly struct KeyValueYield<TKey, TValue>
	{
		private readonly TKey _key;
		private readonly TValue _value;
		private readonly Action<TValue> _context;
		
		
		public KeyValueYield
		(
			TKey key,
			TValue value,
			Action<TValue> context
		)
		{
			_key = key;
			_value = value;
			_context = context;
		}
		
		
		public TKey Key
		{
			get
			{
				return _key;
			}
		}
		
		public TValue Value
		{
			get
			{
				return _value;
			}
		}
		
		public Action<TValue> Context
		{
			get
			{
				return _context;
			}
		}
		
		public void Deconstruct
		(
			out TKey key,
			out TValue value,
			out Action<TValue> context
		)
		{
			key = Key;
			value = Value;
			context = Context;
			
			return;
		}
		
		public override string ToString
		(
		)
		{
			return string.Format("[{0}, {1}, {2}]", Key, Value, Context);
		}	
	}
}