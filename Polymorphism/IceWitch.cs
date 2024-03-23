using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWitch : Adventurer
{
    public override void Attack()
    {
        Debug.Log("2nd Job: Ice Witch");
        base.Attack();
    }
}
