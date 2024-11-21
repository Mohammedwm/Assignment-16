using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();
        // Start is called before the first frame update
        
        public void AddItem(string item){
            items.Add(item);
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
               Debug.Log(item); 
            }
        }

        public static Inventory operator +(Inventory a, Inventory b)
        {
           Inventory CombineBoth = new Inventory();
           forLoop(CombineBoth,a);
           forLoop(CombineBoth,b);
           return CombineBoth;
        }
        public static void forLoop(Inventory CombineBoth , Inventory arr)
        {
            foreach (var item in arr.items)
           {
                CombineBoth.AddItem(item);
           }  
        }
    }
}