using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IT_Holiichuk
{
    class Value
    {
        public object value { get; private set; }
        public string valueType { get; private set; }
        public bool IsWrongValueType { get; }

        public string AttributeName { get; }

        public Value(object _value, string attributeName)
        {
            var _valueType = CheckValueType(_value);

            if(_valueType != null)
            {
                valueType = _valueType;
                value = _value;
                IsWrongValueType = false;
            }
            else
            {
                valueType = "Wrong value type";
                value = "Wrong value";
                IsWrongValueType = true;
            }

            AttributeName = attributeName;
        }

        private string CheckValueType(object _value)
        {
            if (_value is int)
                return "Integer";

            if (_value is double)
                return "Real";

            if (_value is char)
                return "Char";

            if (_value is string)
                return "String";

            else return null;
        }

        public void EditValue(Value newValue)
        {
            if (newValue.valueType == valueType)
                value = newValue.value;

            else throw new Exception($"Error while editing value {value}, new value type {newValue.valueType} is incorrect");
        }
    }
}
