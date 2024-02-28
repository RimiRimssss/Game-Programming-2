using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Pokemon", menuName = "ScriptableObjects/Pokemon")]
public class Pokemon : ScriptableObject
{
    [Header("Pokemon Info")]
    public Sprite Image;
    public string Name;
    public int pokeDexNum;
    public int lvl;
    public string nature; //nature ex. Adamant, Brave, Calm, etc.
    public string heldItem; //if it holds an item or not
    public string state; //whether it has a status condition or not
    public string type; //typing: fire water grass etc.
    public string gender; //m or f

    [Header("Pokemon Stats")]
    public int HP;
    public int ATK;
    public int DEF;
    public int SPATK;
    public int SPDEF;
    public int SPD;

    [Header("Pokemon Moves")]
    public string abiOne;
    public string abiTwo;
    public string abiThree;
    public string abiFour;
}
