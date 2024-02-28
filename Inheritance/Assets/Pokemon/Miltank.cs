using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miltank : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Miltank";
        pokeDexNumber = 241;
        level = 50;
        heldItem = "Weakness Policy";
        ability = "Thick Fat";
        gender = Gender.Female;
        appearance = Appearance.Normal;
        type = Type.Normal;
        type2 = Type.None;
        nature = Nature.Careful;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 150;
        stats.ATK = 100;
        stats.DEF = 110;
        stats.SPATK = 153;
        stats.SPDEF = 126;
        stats.SPD = 50;
    }

}

