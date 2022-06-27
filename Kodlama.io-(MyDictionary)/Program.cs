using System;

namespace Kodlama.io__MyDictionary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Merto");
            myDictionary.Add(2, "Anıl");
            Console.WriteLine(myDictionary.Count);
        }
    }
    class MyDictionary<K, V>
    {
        K[] _k;
        V[] _v;
        public MyDictionary()
        {
            _k = new K[0];
            _v = new V[0];

        }
        public void Add(K key, V value)
        {
            K[] tempKey = _k;
            V[] tempValue = _v;
            _k = new K[_k.Length + 1];
            _v = new V[_v.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                _k[i] = tempKey[i];
                _v[i] = tempValue[i];
            }
            _k[_k.Length - 1] = key;
            _v[_k.Length - 1] = value;


        }
        public int Count
        {
            get { return _k.Length; }
           
        }






    }
}
