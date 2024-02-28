using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    [Header("Info")]
    public string name;
    public int pokeDexNumber;
    public int level;
    public string heldItem;
    public string ability;
    public Gender gender;
    public Appearance appearance;
    public Type type; public Type type2;
    public Nature nature;
    public Gimmick gimmick;
    public string owner;
    public Stats stats;

    [System.Serializable]
    public class Stats
    {
         [Header("Stats")]
         public int HP;
         public int ATK;
         public int DEF;
         public int SPATK;
         public int SPDEF;
         public int SPD;
    }
   

    void Start()
    {
        switch (gender)
        {
            case Gender.Male: Debug.Log("Male"); break;
            case Gender.Female: Debug.Log("Female"); break;
            case Gender.None: Debug.Log("None"); break;
        }
        switch (type)
        {
            case Type.Fire: Debug.Log("Fire"); break;
            case Type.Water: Debug.Log("Water"); break;
            case Type.Grass: Debug.Log("Grass"); break;
            case Type.Flying: Debug.Log("Flying"); break;
            case Type.Rock: Debug.Log("Rock"); break;
            case Type.Ground: Debug.Log("Ground"); break;
            case Type.Bug: Debug.Log("Bug"); break;
            case Type.Dragon: Debug.Log("Dragon"); break;
            case Type.Normal: Debug.Log("Normal"); break;
            case Type.Ice: Debug.Log("Ice"); break;
            case Type.Poison: Debug.Log("Poison"); break;
            case Type.Steel: Debug.Log("Steel"); break;
            case Type.Psychic: Debug.Log("Psychic"); break;
            case Type.Dark: Debug.Log("Dark"); break;
            case Type.Ghost: Debug.Log("Ghost"); break;
            case Type.Fairy: Debug.Log("Fairy"); break;
            case Type.Fighting: Debug.Log("Fighting"); break;
            case Type.Electric: Debug.Log("Electric"); break;
            case Type.None: Debug.Log("None"); break;
        }
        switch (nature)
        {
            case Nature.Adamant: Debug.Log("Adamant"); break;
            case Nature.Bashful: Debug.Log("Bashful"); break;
            case Nature.Bold: Debug.Log("Bold"); break;
            case Nature.Brave: Debug.Log("Brave"); break;
            case Nature.Calm: Debug.Log("Calm"); break;
            case Nature.Careful: Debug.Log("Careful"); break;
            case Nature.Docile: Debug.Log("Docile"); break;
            case Nature.Gentle: Debug.Log("Gentle"); break;
            case Nature.Hardy: Debug.Log("Hardy"); break;
            case Nature.Hasty: Debug.Log("Hasty"); break;
            case Nature.Impish: Debug.Log("Impish"); break;
            case Nature.Jolly: Debug.Log("Jolly"); break;
            case Nature.Lax: Debug.Log("Lax"); break;
            case Nature.Lonely: Debug.Log("Lonely"); break;
            case Nature.Mild: Debug.Log("Mild"); break;
            case Nature.Modest: Debug.Log("Modest"); break;
            case Nature.Naive: Debug.Log("Naive"); break;
            case Nature.Naughty: Debug.Log("Naughty"); break;
            case Nature.Quiet: Debug.Log("Quiet"); break;
            case Nature.Quirky: Debug.Log("Quirky"); break;
            case Nature.Rash: Debug.Log("Rash"); break;
            case Nature.Relaxed: Debug.Log("Relaxed"); break;
            case Nature.Sassy: Debug.Log("Sassy"); break;
            case Nature.Serious: Debug.Log("Serious"); break;
            case Nature.Timid: Debug.Log("Timid"); break;
        }
        switch (gimmick)
        {
            case Gimmick.MegaEvolve: Debug.Log("MegaEvolve"); break;
            case Gimmick.Dynamax: Debug.Log("Dynamax"); break;
            case Gimmick.Terastallize: Debug.Log("Terastallize"); break;
            case Gimmick.Gigantamax: Debug.Log("Gigantamax"); break;
            case Gimmick.ZMove: Debug.Log("ZMove"); break;
            case Gimmick.AshGreninja: Debug.Log("AshGreninja"); break;
            case Gimmick.None: Debug.Log("None"); break;
        }
        switch (appearance)
        {
            case Appearance.Shiny: Debug.Log(""); break;
            case Appearance.Shadow: Debug.Log(""); break;
            case Appearance.Normal: Debug.Log(""); break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
