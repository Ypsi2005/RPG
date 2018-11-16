using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {


    public int Hp { get; set; }
    public int Mana { get; set; }
    public int Range { get; set; }
    public int Lvl { get; set; }

    public int AtK { get; set; }
    public int Def{ get; set; }
    public int Mag { get; set; }
    public int MDF { get; set; }
    public int Agi { get; set; }
    public int Luk { get; set; }
    public int Acc { get; set; }
    public int Cha { get; set; }
    public int Fok { get; set; }
    public int Wis { get; set; }
    public int Dex { get; set; }

    public int Fire { get; set; }
    public int Ice { get; set; }
    public int Poison { get; set; }
    public int Lighting { get; set; }
    public int Unholy { get; set; }
    public int Holy { get; set; }



    public virtual void Move(int agi)
    {

    }

    public virtual void DmgDone()
    {

    }
}
