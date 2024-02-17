using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampharos : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Ampharos";
        pokeDexNumber = 181;
        level = 50;
        heldItem = "Ampharosite";
        ability = "Mold Breaker";
        gender = Gender.Female;
        appearance = Appearance.Normal;
        type = Type.Electric;
        type2 = Type.Dragon;
        nature = Nature.Gentle;
        gimmick = Gimmick.MegaEvolve;
        owner = "RimiRimsss";
        stats.HP = 150;
        stats.ATK = 100;
        stats.DEF = 99;
        stats.SPATK = 170;
        stats.SPDEF = 126;
        stats.SPD = 50;
    }

}

