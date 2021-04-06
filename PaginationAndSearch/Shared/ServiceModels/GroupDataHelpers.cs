using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Telerik.DataSource;

namespace PaginationAndSearch.Shared.ServiceModels
{
    public static class GroupDataHelpers
    {
        public static List<AggregateFunctionsGroup> DeserializedGroups<TGroupItem>(List<AggregateFunctionsGroup> groups)
        {
            if(groups != null)
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    var group = groups[i];
                    var groupItems = group.Items.Cast<JsonElement>().ToList();

                    if (group.HasSubgroups)
                    {
                        var deseralizedItems = groupItems
                            .Select(x => x.Deserialize<AggregateFunctionsGroup>(new JsonSerializerOptions()
                            {
                                PropertyNameCaseInsensitive = true
                            }))
                            .ToList();

                        var items = deseralizedItems.Cast<AggregateFunctionsGroup>().ToList();
                        var subgroups = DeserializedGroups<TGroupItem>(items);
                        group.Items = subgroups;
                    }
                    else
                    {
                        var deserializedItems = groupItems
                            .Select(x => x.Deserialize<TGroupItem>(new JsonSerializerOptions()
                            {
                                PropertyNameCaseInsensitive = true
                            }))
                            .ToList();

                        group.Items = deserializedItems;
                    }
                }
            }
            return groups;
        }
    }
}
