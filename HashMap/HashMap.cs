using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapImpl
{
    public class HashMap
    {
        private Reference[] hash;
        private int arrLength;
        private int elements;

        public HashMap()
        {
            arrLength = 26;
            elements = 0;
            hash = new Reference[arrLength];
        }



        public void resize()
        {

        }

        public void insert(string key, Object value)
        {
            elements++;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(key);
            int sum = 0;
            foreach(byte b in asciiBytes)
            {
                sum += b;
            }
            if (hash[sum % arrLength] == null)
            {
                hash[sum % arrLength] = new Reference(key, value, sum, sum % arrLength);
            }
            else
            {
                hash[sum % arrLength].insert(key, value, sum, sum % arrLength);
            }
        }

        public Object retrieve(string key)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(key);
            int sum = 0;
            foreach (byte b in asciiBytes)
            {
                sum += b;
            }
            return hash[sum % arrLength].retrieve(key);
        }

        public int getElements()
        {
            return elements;
        }
    }


    public class Reference
    {
        private string key;
        private Object value;
        private int sum;
        private int mod;
        private Reference next;

        public Reference(string key, Object value, int sum, int mod)
        {
            this.key = key;
            this.value = value;
            this.sum = sum;
            this.mod = mod;
        }
        public bool insert(string key, Object value, int sum, int mod)
        {
            if (key.Equals(this.key))
            {
                return false;
            }
            if(next == null)
            {
                next = new Reference(key, value, sum, mod);
                return true;
            }
            else
            {
                return next.insert(key, value, sum, mod);
            }
        }
        public Object retrieve(string key)
        {
            if(key.Equals(this.key))
            {
                return value;
            }
            else
            {
                return next.retrieve(key);
            }
        }
    }
}
