using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

[System.Serializable]
[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character")]
public class Character : ScriptableObject
{
    [Header("Stats")]
    public Sprite image;
    public string name;
    public int LVL;
    public int HP;
    public int MP;
    public int ATK;
    public int DEF;
    public int INT;
    public int LUK;
    public int AGI;
    public int MND;

    [Header("Ability")]
    public string abilityOne;
    public string abilityTwo;
    public string abilityThree;
    public string abilityFour;
    public string specialAbility;
}

