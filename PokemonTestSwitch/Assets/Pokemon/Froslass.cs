using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Froslass : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Froslass";
        pokeDexNumber = 478;
        level = 50;
        heldItem = "Icy Rock";
        ability = "Snow Cloak";
        gender = Gender.Female;
        appearance = Appearance.Normal;
        type = Type.Ice;
        type2 = Type.Ghost;
        nature = Nature.Sassy;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 130;
        stats.ATK = 85;
        stats.DEF = 75;
        stats.SPATK = 85;
        stats.SPDEF = 82;
        stats.SPD = 103;
    }

}

