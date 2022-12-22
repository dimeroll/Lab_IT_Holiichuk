using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IT_Holiichuk
{
    class TableRow
    {
        public List<string> AttributeNames { get; }

        private List<Value> values;

        public TableRow(List<string> attributeNames, List<Value> _values)
        {
            AttributeNames = attributeNames;
            values = _values;
        }

        public Value this[string attributeName]
        {
            get
            {
                foreach(Value value in values)
                {
                    if(value.AttributeName == attributeName)
                    {
                        return value;
                    }
                }

                return null;
            }
        }

        public Value this[int index]
        {
            get
            {
                return values[index];
            }
        }

        public void AddValue(Value value)
        {
            AttributeNames.Add(value.AttributeName);
            values.Add(value);
        }

        public void DeleteValue(Value _value)
        {
            foreach (var value in values)
                if (value.value == _value.value)
                {
                    values.Remove(value);
                    AttributeNames.Remove(value.AttributeName);
                    break;
                }
        }

        public void DeleteValue(int index)
        {
            values.RemoveAt(index);
            AttributeNames.RemoveAt(index);
        }
    }
}
