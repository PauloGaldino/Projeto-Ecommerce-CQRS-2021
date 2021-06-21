using Ecommerce.Domain.Core.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.EventSourcedNormalizers.Products
{
    public class ProductHistory
    {
        public static IList<ProductHistoryData> HistoryData { get; set; }

        public static IList<ProductHistoryData> ToJavascriptProductHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<ProductHistoryData>();
            ProductHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(p => p.When);
            var list = new List<ProductHistoryData>();
            var last = new ProductHistoryData();

            foreach (var change in sorted)
            {
                var jsSlot = new ProductHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id ? "" : change.Id,
                    Name = string.IsNullOrWhiteSpace(change.Name) || change.Name == last.Name ? "" : change.Name,
                    Value = change.Value == decimal.Zero || change.Value == last.Value ? 0 : change.Value,
                    State = change.State == false || change.State == last.State ? false : change.State,

                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    When = change.When,
                    Who = change.Who
                };
                list.Add(jsSlot);
                last = change;
            }
            return list;
        }

        private static void ProductHistoryDeserializer(IList<StoredEvent> storedEvents)
        {
            foreach (var e in storedEvents)
            {
                var slot = new ProductHistoryData();
                dynamic values;

                switch (e.MessageType)
                {

                    case "ProductRegisteredEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.State = values["State"];
                        slot.Value = values["Value"];
                        slot.Name = values["Name"];
                        slot.Action = "Registered";
                        slot.When = values["Timestamp"];
                        slot.Id = values["Id"];
                        slot.Who = e.User;
                        break;

                    case "ProductUpdatedEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.State = values["State"];
                        slot.Value = values["Value"];
                        slot.Name = values["Name"];
                        slot.Action = "Updated";
                        slot.When = values["Timestamp"];
                        slot.Id = values["Id"];
                        slot.Who = e.User;
                        break;

                    case "ProductRemovedEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.Action = "Removed";
                        slot.When = values["Timestamp"];
                        slot.Id = values["Id"];
                        slot.Who = e.User;
                        break;
                }

            }
        }
    }
}

