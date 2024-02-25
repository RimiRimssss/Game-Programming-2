using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterInfoView : MonoBehaviour
{
    public Character character;

    [Header("Stats")]
    public Image image;
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI lvlTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI mpTMP;
    public TextMeshProUGUI atkTMP;
    public TextMeshProUGUI defTMP;
    public TextMeshProUGUI intTMP;
    public TextMeshProUGUI lukTMP;
    public TextMeshProUGUI agiTMP;
    public TextMeshProUGUI mndTMP;




    public void OnEnable()
    {
        //DisplayCharacter(character);
    }
    public void DisplayCharacter(Character character)
    {
        image.sprite = character.image;
        nameTMP.text = character.name;
        lvlTMP.text = character.LVL.ToString();
        hpTMP.text = character.HP.ToString();
        mpTMP.text = character.MP.ToString();
        atkTMP.text = character.ATK.ToString();
        defTMP.text = character.DEF.ToString();
        intTMP.text = character.INT.ToString();
        lukTMP.text = character.LUK.ToString();
        agiTMP.text = character.AGI.ToString();
        mndTMP.text = character.MND.ToString();



    }

    public void ClearView()
    {
        image.sprite = null;
        nameTMP.text = null;
        character = null;
        lvlTMP.text = null;
        hpTMP.text = null;
        mpTMP.text = null;
        atkTMP.text = null;
        defTMP.text = null;
        intTMP.text = null;
        lukTMP.text = null;
        agiTMP.text = null;
        mndTMP.text = null;
    }
    public void OnDisable()
    {
        ClearView();
    }
}
