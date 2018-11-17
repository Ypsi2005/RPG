using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    static readonly System.Random _rnd = new System.Random();

    private Dictionary<int, Item> _items = new Dictionary<int, Item>()
    {
        {1, new Item{Name = "Schwert", Stat1 = _rnd.Next(1,10), Stat2 = _rnd.Next(1,10)} },
        {2, new Item{Name = "Axt", Stat1 = _rnd.Next(1,10), Stat2 = _rnd.Next(1,10)} },
        {3, new Item{Name = "Speer", Stat1 = _rnd.Next(1,10), Stat2 = _rnd.Next(1,10)} }

    };


    public void Test()
    {
        var testRand = _rnd.Next(1, 4);

        var result = _items[testRand];

        Debug.Log(result.Name + " test " + result.Stat1);
    }

    void Update()
    {
        Test();
    }

}
