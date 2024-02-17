using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flygon : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Flygon";
        pokeDexNumber = 330;
        level = 50;
        heldItem = "Dragon Fang";
        ability = "Levitate";
        gender = Gender.Female;
        appearance = Appearance.Normal;
        type = Type.Ground;
        type2 = Type.Dragon;
        nature = Nature.Jolly;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 140;
        stats.ATK = 105;
        stats.DEF = 85;
        stats.SPATK = 76;
        stats.SPDEF = 85;
        stats.SPD = 115;
    }

}

