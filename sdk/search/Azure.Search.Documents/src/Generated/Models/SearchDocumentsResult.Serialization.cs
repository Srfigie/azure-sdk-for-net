// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchDocumentsResult
    {
        internal static SearchDocumentsResult DeserializeSearchDocumentsResult(JsonElement element)
        {
            long? odatacount = default;
            double? searchcoverage = default;
            IReadOnlyDictionary<string, IList<FacetResult>> searchfacets = default;
            SearchOptions searchnextPageParameters = default;
            IReadOnlyList<SearchResult> value = default;
            string odatanextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odatacount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.coverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchcoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.facets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<FacetResult>> dictionary = new Dictionary<string, IList<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<FacetResult> array = new List<FacetResult>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(FacetResult.DeserializeFacetResult(item));
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    searchfacets = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.nextPageParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchnextPageParameters = SearchOptions.DeserializeSearchOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<SearchResult> array = new List<SearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchResult.DeserializeSearchResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odatanextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SearchDocumentsResult(odatacount, searchcoverage, searchfacets, searchnextPageParameters, value, odatanextLink);
        }
    }
}