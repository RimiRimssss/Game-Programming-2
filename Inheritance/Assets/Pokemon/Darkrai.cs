using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkrai : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Darkrai";
        pokeDexNumber = 491;
        level = 50;
        heldItem = "Quick Claw";
        ability = "Bad Dreams";
        gender = Gender.Male;
        appearance = Appearance.Normal;
        type = Type.Dark;
        type2 = Type.None;
        nature = Nature.Relaxed;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 130;
        stats.ATK = 95;
        stats.DEF = 104;
        stats.SPATK = 140;
        stats.SPDEF = 95;
        stats.SPD = 117;
    }

}

