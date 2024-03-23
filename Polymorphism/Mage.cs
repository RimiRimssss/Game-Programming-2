using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Adventurer
{
    public override void Attack()
    {
        Debug.Log("1st Job: Mage");
        base.Attack();
    }
}
