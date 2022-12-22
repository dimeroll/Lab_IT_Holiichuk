using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IT_Holiichuk
{
    class Table
    {
        public int TableId { get; }
        public string TableName { get; }

        public List<string> AttributeNames { get; }

        private List<TableAttribute> attributes;

        private List<TableRow> rows;

        public Table(int tableId, string name, List<TableAttribute> tableAttributes, List<TableRow> tableRows)
        {
            TableId = tableId;
            TableName = name;
            attributes = tableAttributes;
            rows = tableRows;

            AttributeNames = attributes
                .Select(attribute => attribute.AttributeName)
                .ToList();
        }

        public void AddAttribute(TableAttribute attribute)
        {
            attributes.Add(attribute);
        }

        public void DeleteAttribute(string attributeName)
        {
            foreach(TableAttribute attribute in attributes)
            {
                if(attribute.AttributeName == attributeName)
                {
                    attributes.Remove(attribute);
                    break;
                }
            }
        }

        public void AddRow(TableRow row)
        {
            int i = 0;
            foreach(var attributeName in AttributeNames)
            {
                if (attributeName != row.AttributeNames[i])
                    return;
                i++;
            }
            rows.Add(row);
        }

        public void DeleteRow(int rowNumber)
        {
            rows.RemoveAt(rowNumber);
        }
    }
}
