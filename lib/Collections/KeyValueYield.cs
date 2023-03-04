/*
	SPDX-License-Identifer: Apache-2.0 OR LGPL-3.0-or-later
    SPDX-FileCopyrightText: 2023 Mervin G.

	SPDX-FileType: SOURCE

	SPDX-FileComment: Factory for key-value-delegate bundles.
*/

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