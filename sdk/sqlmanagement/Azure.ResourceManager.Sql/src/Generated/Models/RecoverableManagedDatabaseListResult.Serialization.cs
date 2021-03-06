// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecoverableManagedDatabaseListResult
    {
        internal static RecoverableManagedDatabaseListResult DeserializeRecoverableManagedDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RecoverableManagedDatabase>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RecoverableManagedDatabase> array = new List<RecoverableManagedDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoverableManagedDatabase.DeserializeRecoverableManagedDatabase(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RecoverableManagedDatabaseListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
