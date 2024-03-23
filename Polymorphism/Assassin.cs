using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassin : Adventurer
{
    public override void Attack()
    {
        Debug.Log("2nd Job: Assassin");
        base.Attack();
    }
}
