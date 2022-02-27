using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _dictionaryKey;
        TValue[] _dictionaryValue;



        public MyDictionary()  // constructor.
        {
            _dictionaryKey = new TKey[0];      // sıfır elemanlı bir dizi oluşturduk
            _dictionaryValue = new TValue[0];  // sıfır elemanlı bir dizi oluşturduk
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempkey = _dictionaryKey;
            TValue[] tempvalue = _dictionaryValue;

            _dictionaryKey = new TKey[_dictionaryKey.Length + 1]; // her eleman eklemesinde bir artırırız. Ancak diğerleri gider newlediğimiz için. birisine emanet vermek gerekir.
            _dictionaryValue = new TValue[_dictionaryValue.Length + 1];

            for(int i = 0; i < tempkey.Length; i++)
            {
                _dictionaryKey[i] = tempkey[i];
                _dictionaryValue[i] = tempvalue[i];
            }

            _dictionaryKey[_dictionaryKey.Length - 1] = key; 
            _dictionaryValue[_dictionaryValue.Length - 1] = value;
        }

        public int Count
        {
            get { return _dictionaryKey.Length; }
        }
    }
}
