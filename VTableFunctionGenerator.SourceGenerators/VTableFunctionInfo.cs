// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

namespace U5BFA.Libraries;

internal record VTableFunctionInfo(
	string FullyQualifiedParentTypeName,
	string ParentTypeNamespace,
	string ParentTypeName,
	bool IsReturnTypeVoid,
	string Name,
	string ReturnTypeName,
	int Index,
	EquatableArray<ParameterTypeNamePair> Parameters);
