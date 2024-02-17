using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Sceptile : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Sceptile";
        pokeDexNumber = 254;
        level = 50;
        heldItem = "Sceptilite";
        ability = "Lightning Rod";
        gender = Gender.Male;
        appearance = Appearance.Normal;
        type = Type.Grass;
        type2 = Type.Dragon;
        nature = Nature.Adamant;
        gimmick = Gimmick.MegaEvolve;
        owner = "RimiRimsss";
        stats.HP = 130;
        stats.ATK = 126;
        stats.DEF = 80;
        stats.SPATK = 135;
        stats.SPDEF = 90;
        stats.SPD = 150;

    }

}
