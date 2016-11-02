// Joshua Harding - (id)
// partner name - (id)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable
{
    public enum TStatus {EMPTY, FULL, DELETED}
    
    public class HashTable<TKey, TValue>
    {
        private class Entry
        {
            public TKey Key { get; set; }
            public TValue Item { get; set; }
            public TStatus Status { get; set; }
            // etc.
        }
        
        private Entry[] table;  // array of entries
        private int size;       // capacity of the hash table
        private int count;      // number of entries in the hash table
        private int scheme;     // 1 for linear, 2 for quadratic
        
        // Note for mant methods below, the GetHashCode of TKey is needed
        
        // Creates an empty hash table of size using 
        // the resolution scheme 1 for linear and 2 for quadratic
        public HashTable(int size, int scheme)
        {
            // code here
        }
        
        // Adds an item with key to the hash table (keys must be unique)
        public void Add(TKey key, TValue item)
        {
            // code here
        }
        
        // Removes the item with key from the hash table and returns true if done; false otherwise
        public bool Remove(TKey key)
        {
            // code here
        }
        
        // Returns true if the key is used in the hash table; false otherwise
        public bool ContainsKey(TKey key)
        {
            // code here
        }
        
        // Returns the item with key if found; default(TValue) otherwise
        public TValue Retrieve(TKey key)
        {
            // code here
        }
        
        // Uses linear probing to return the next available (EMPTY/DELETED) index in the table
        private int Linear (int i)
        {
            // code here
            return 1;   // delete this, its just to stop the error
        }
        
        // Uses quadratic probing to return the next availible (EMPTY/DELETED) index in the table
        private int Quadratic (int i)
        {
            // code here
            return 1; // delete this, its just to stop the error
        }
        
        // Custom function to check if a number is prime.
        // (Has been tested and compared to an official list of the first 10 000 prime numbers)
        // number -> bool (O(n) time complexity)
        public static bool IsPrime(int number)
        {
            if (number <= 1) // zero and one are not prime
                return false;
            for (int i = 2; i * i <= number; i++) // only go until i*i, because we are checking if our number is divisible
            {
                if (number % i == 0)
                    return false;   // if number is divisible by i, then it is not prime.
            }
            return true;    // if nothing else falls through, the number is prime.
        }
    }
}
