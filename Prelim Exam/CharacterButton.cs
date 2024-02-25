using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class CharacterButton : MonoBehaviour
{
    [Header("UI Headers")]
    public Image image;
    public TextMeshProUGUI nameText;


    public void SetCharacterData(Character unit)
    {
        nameText.text = unit.name;
        image.sprite = unit.image;
    }
}
