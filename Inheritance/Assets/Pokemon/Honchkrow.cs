using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honchkrow : Pokemon
{
    void Start()
    {
        stats = new Stats();
        name = "Honchkrow";
        pokeDexNumber = 430;
        level = 50;
        heldItem = "Sharp Beak";
        ability = "Moxie";
        gender = Gender.Male;
        appearance = Appearance.Normal;
        type = Type.Dark;
        type2 = Type.Flying;
        nature = Nature.Hasty;
        gimmick = Gimmick.None;
        owner = "RimiRimsss";
        stats.HP = 160;
        stats.ATK = 130;
        stats.DEF = 51;
        stats.SPATK = 110;
        stats.SPDEF = 57;
        stats.SPD = 83;
    }

}

