using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryLearn
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKeyArray = _key;
            TValue[] _tempValueArray = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _key[i] = _tempKeyArray[i];
                _value[i] = _tempValueArray[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Count
        {
            get { return _key.Length; }
        }
    }
}
