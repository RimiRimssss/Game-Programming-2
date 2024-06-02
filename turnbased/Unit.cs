using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int damage;
    public int defence;

    public int maxHP;
    public int currentHP;

    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg - defence;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if(currentHP > maxHP)
            currentHP = maxHP;
    }

    public void Defence(int amount)
    {
        defence += amount;
    }

    public void NotDefend(int amount)
    {
        defence -= amount;
    }
}
