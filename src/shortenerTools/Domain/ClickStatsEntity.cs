using System;
using System.Linq;
using Microsoft.Azure.Cosmos.Table;

namespace Cloud5mins.domain
{
    public class ClickStatsEntity : TableEntity
    {
        public string Datetime { get; set; }

        public ClickStatsEntity(){}

        public ClickStatsEntity(string vanity){
            PartitionKey = vanity;
            RowKey = Guid.NewGuid().ToString();
            Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }
    }


}
