using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Adventurer
{
    public override void Attack()
    {
        Debug.Log("2nd Job: Rogue");
        base.Attack();
    }
}
