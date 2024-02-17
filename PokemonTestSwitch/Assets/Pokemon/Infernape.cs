using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infernape : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Infernape";
        pokeDexNumber = 392;
        level = 50;
        heldItem = "Charcoal";
        ability = "Blaze";
        gender = Gender.Male;
        appearance = Appearance.Shiny;
        type = Type.Fire;
        type2 = Type.Fighting;
        nature = Nature.Brave;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 136;
        stats.ATK = 119;
        stats.DEF = 76;
        stats.SPATK = 109;
        stats.SPDEF = 76;
        stats.SPD = 101;
    }

}

