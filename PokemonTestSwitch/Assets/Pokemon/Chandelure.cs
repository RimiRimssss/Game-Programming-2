using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chandelure : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Chandelure";
        pokeDexNumber = 609;
        level = 50;
        heldItem = "Focus Band";
        ability = "Flash Fire";
        gender = Gender.Female;
        appearance = Appearance.Shiny;
        type = Type.Ghost;
        type2 = Type.Fire;
        nature = Nature.Quiet;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 120;
        stats.ATK = 60;
        stats.DEF = 95;
        stats.SPATK = 165;
        stats.SPDEF = 95;
        stats.SPD = 76;
    }

}

