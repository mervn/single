using System;


namespace Meg.Delta.Collections
{
	[Serializable]
	public readonly struct KeyValueYield<TKey, TValue>
	{
		private readonly TKey _key;
		private readonly (TValue, bool) _value;
		private readonly Action<TKey, TValue> _process;
		
		
		public KeyValueYield
		(
			TKey key,
			(TValue, bool) value,
			Action<TKey, TValue> process
		)
		{
			_key = key;
			_value = value;
			_process = process;
		}
		
		
		public TKey Key
		{
			get
			{
				return _key;
			}
		}
		
		public (Content: TValue, NaN: bool) Value
		{
			get
			{
				return _value;
			}
		}
		
		public Action<TKey, TValue> Process
		{
			get
			{
				return _process;
			}
		}
		
		public void Deconstruct
		(
			out TKey key,
			out (Content: TValue, NaN: bool) value,
			out Action<TKey, TValue> process
		)
		{
			key = Key;
			value = Value;
			process = Process;
			
			return;
		}
		
		public override string ToString
		(
		)
		{
			return string.Format("[{0}, {1}, {2}]", Key, Value.Content, Process);
		}	
	}
}