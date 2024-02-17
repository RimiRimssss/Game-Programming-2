using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breloom : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Breloom";
        pokeDexNumber = 286;
        level = 50;
        heldItem = "Expert Belt";
        ability = "Effect Spore";
        gender = Gender.Male;
        appearance = Appearance.Normal;
        type = Type.Grass;
        type2 = Type.Fighting;
        nature = Nature.Rash;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 120;
        stats.ATK = 135;
        stats.DEF = 85;
        stats.SPATK = 71;
        stats.SPDEF = 58;
        stats.SPD = 75;
    }

}

