// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using System;

namespace U5BFA.Libraries;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class GeneratedVTableFunctionAttribute : Attribute
{
	public required int Index { get; init; }
}
