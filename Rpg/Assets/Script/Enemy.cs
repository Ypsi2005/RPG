using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Enemy : Character {

    public List<Item> Loot;
    public int ExpDrop { get; set; }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void die(int Hp)
    {
        base.die(Hp);
        dropLoot();
    }

    void dropLoot()
    {
        Random rnd = new Random();
      
        
    }
}
