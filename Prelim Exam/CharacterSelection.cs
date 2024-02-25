using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public CharacterManager characterManager; //getting data of scriptable objects (pokemon)
    public Transform parentPos;
    public GameObject characterButtonPrefab;
    public CharacterInfoView characterInfoView;
    public GameObject characterSelect;

    void Start()
    {
        //Debug.Log(characterManager.characters.Count());
        foreach (Character c in characterManager.characters)
        {
            GameObject buttonPrefab = Instantiate(characterButtonPrefab, parentPos);
            CharacterButton characterButton = buttonPrefab.GetComponent<CharacterButton>();
            characterButton.SetCharacterData(c);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => characterInfoView.DisplayCharacter(c));
            button.onClick.AddListener(() => characterSelect.gameObject.SetActive(false));
            button.onClick.AddListener(() => characterInfoView.gameObject.SetActive(true));
        }

    }
}
