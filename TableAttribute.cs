using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IT_Holiichuk
{
    class TableAttribute
    {
        public string AttributeName { get; }
        public string AttributeType { get;  }

        private List<Value> values = new List<Value>();

        public TableAttribute(string attributeName, List<Value> _values, string attributeType)
        {
            AttributeName = attributeName;
            AttributeType = attributeType;
            values = _values;
        }

        public Value this[int index]
        {
            get => values[index];
            set
            {
                if (value.valueType == AttributeType)
                    values[index] = value;
            }
        }

        public void AddValue(Value value)
        {
            if (value.valueType == AttributeType)
                values.Add(value);
        }

        public void DeleteValue(Value _value)
        {
            foreach(var value in values)
                if(value.value == _value.value)
                {
                    values.Remove(value);
                    break;
                }
        }

        public void DeleteValue(int index)
        {
            values.RemoveAt(index);
        }
    }
}
