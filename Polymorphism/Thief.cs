using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Adventurer
{

    public override void Attack()
    {
        Debug.Log("1st Job: Thief");
        base.Attack();
    }
}
