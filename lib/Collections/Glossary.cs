/*
	SPDX-License-Identifer: Apache-2.0 OR LGPL-3.0-or-later
    SPDX-FileCopyrightText: 2023 Mervin G.

	SPDX-FileType: SOURCE

	SPDX-FileComment: Collection of key-value-delegate bundles.
*/

using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Meg.Delta.Collections
{
	public class Glossary<TKey, TValue> where TKey : notnull
	{
		private readonly Dictionary<TKey, KeyValueYield<TKey, TValue>> _set = new();


		public bool this[TKey key]
		{
			get => new NotImplementedException();
		}


		public void Add(TKey key, TValue value)
		{
			return new NotImplementedException();
		}

		public void Add(TKey key, Action<TKey, TValue> process)
		{
			return new NotImplementedException();
		}

		public void Add(TKey key, TValue value, Action<TKey, TValue> process)
		{
			return new NotImplementedException();
		}

		public bool Remove(TKey key)
		{
			return new NotImplementedException();
		}

		public bool Resolve(TKey key, bool force = false)
		{
			return new NotImplementedException();
		}

		public void Update(TKey key, TValue value)
		{
			return new NotImplementedException();
		}

		public void Update(TKey key, Action<TKey, TValue> process)
		{
			return new NotImplementedException();
		}

		public void Update(TKey key, TValue value, Action<TKey, TValue> process)
		{
			return new NotImplementedException();
		}
	}
}
