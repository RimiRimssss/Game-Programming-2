using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMage : Adventurer
{
    public override void Attack()
    {
        Debug.Log("2nd Job: Dark Mage");
        base.Attack();
    }
}
