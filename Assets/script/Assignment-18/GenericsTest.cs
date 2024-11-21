using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
    {
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> gc = new GameContainer<string>();
            gc.SetItem("Healing Potion");

            string item = gc.GetItem();
            Debug.Log("Stored item: "+item);

            string desItem = GameUtils.DescribeItem(item);
            Debug.Log(desItem);

        }
    }
}
