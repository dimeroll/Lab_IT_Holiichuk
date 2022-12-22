using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IT_Holiichuk
{
    class Database
    {
        public int BaseId { get; }

        public string BaseName { get; }

        private List<Table> tables;

        private Dictionary<Table, List<Table>> tableRelations;

        public Database(int id, string name, List<Table> _tables, Dictionary<Table, List<Table>> _tableRelations)
        {
            BaseId = id;
            BaseName = name;
            tables = _tables;
            tableRelations = _tableRelations;
        }

        public void AddTable(Table table, List<Table> tablesRelatedTo, Table tableRelatedToThis)
        {
            tables.Add(table);

            if (tablesRelatedTo != null)
                tableRelations.Add(table, tablesRelatedTo);

            if (tableRelatedToThis != null)
                tableRelations[tableRelatedToThis].Add(table);
        }

        public void DeleteTable(Table table)
        {
            tables.Remove(table);
            tableRelations.Remove(table);
            foreach(var relation in tableRelations)
            {
                if (relation.Value.Contains(table))
                    relation.Value.Remove(table);
            }
        }

        public void EditTable(Table table, TableRow tableRow)
        {
            table.AddRow(tableRow);
        }

        public void EditTable(Table table, int rowNumber)
        {
            table.DeleteRow(rowNumber);
        }

        public void EditTable(Table table, TableAttribute attribute)
        {
            table.AddAttribute(attribute);
        }

        public void EditTable(Table table, string attributeName)
        {
            table.DeleteAttribute(attributeName);
        }
    }
}
