using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BattleState { START, PLAYERTURN, ENEMYONETURN, ENEMYTWOTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyOnePrefab;
    public GameObject winPanel;
    public GameObject losePanel;

    Animator playerAnimator;
    Animator orcAnimator;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyOneUnit;

    public TextMeshProUGUI dialogueText;

    public AudioSource playerAtk;
    public AudioSource playerDead;
    public AudioSource playerHeal;
    public AudioSource orcAtk;
    public AudioSource orcDead;
    public AudioSource winSound;
    public AudioSource loseSound;
    public AudioSource playerGuard;

    public bool playerAttacking;
    public bool playerHurting;
    public bool playerHealing;
    public bool playerDeath;
    public bool playerGuarding;
    public bool orcAttacking;
    public bool orcHurting;
    public bool orcDeath;

    public BattleHUD playerHUD;
    public BattleHUD enemyOneHUD;

    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());

        
        
    }

    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();
        playerAnimator = playerGO.GetComponentInChildren<Animator>();

        GameObject enemyGO = Instantiate(enemyOnePrefab, enemyBattleStation);
        enemyOneUnit = enemyGO.GetComponent<Unit>();
        orcAnimator = enemyGO.GetComponentInChildren<Animator>();

        dialogueText.text = "An enemy " + enemyOneUnit.unitName + " approaches.";

        playerHUD.SetHUD(playerUnit);
        enemyOneHUD.SetHUD(enemyOneUnit);

        yield return new WaitForSeconds(5f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyOneUnit.TakeDamage(playerUnit.damage);

        enemyOneHUD.SetHP(enemyOneUnit.currentHP);
        dialogueText.text = "The attack dealt " + playerUnit.damage;
        playerAtk.Play();
        playerAttacking = true;
        playerAnimator.SetBool("isAttacking", true);

        yield return new WaitForSeconds(1f);

        playerAttacking = false;
        playerAnimator.SetBool("isAttacking", false);

        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
            orcDead.Play();
            orcDeath = true;
            orcAnimator.SetBool("isOrcDead", true);

            yield return new WaitForSeconds(3f);

            winPanel.SetActive(true);
            winSound.Play();
        }
        else
        {
            state = BattleState.ENEMYONETURN;
            StartCoroutine(EnemyTurn());
            orcHurting = true;
            orcAnimator.SetBool("isOrcHurt", true);

            yield return new WaitForSeconds(0.5f);

            orcHurting = false;
            orcAnimator.SetBool("isOrcHurt", false);
        }
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyOneUnit.unitName + " damaged you for " + enemyOneUnit.damage;
        orcAtk.Play();
        orcAttacking = true;
        orcAnimator.SetBool("isOrcAttacking", true);

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyOneUnit.damage);
        orcAttacking = false;
        orcAnimator.SetBool("isOrcAttacking", false);
        playerHUD.SetHP(playerUnit.currentHP);

        if(playerGuarding == true)
        {
            playerUnit.NotDefend(5);
            playerGuarding = false;
            playerAnimator.SetBool("isGuarding", false);
        }

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
            playerDead.Play();
            playerDeath = true;
            playerAnimator.SetBool("isDead", true);

            yield return new WaitForSeconds(3f);

            losePanel.SetActive(true);
            loseSound.Play();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
            playerHurting = true;
            playerAnimator.SetBool("isHurt", true);

            yield return new WaitForSeconds(0.5f);

            playerHurting = false;
            playerAnimator.SetBool("isHurt", false);
        }
    }

    void EndBattle()
    {
        if (state == BattleState.WON)
        {
            dialogueText.text = "You won the battle!";
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "You were defeated!";
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = "Choose an action:";
    }

    IEnumerator PlayerShield()
    {
        playerUnit.Defence(5);
        dialogueText.text = "Preparing for damage.";
        playerGuard.Play();
        playerGuarding = true;
        playerAnimator.SetBool("isGuarding", true);

        yield return new WaitForSeconds(1f);

        state = BattleState.ENEMYONETURN;
        StartCoroutine(EnemyTurn());
    }
    IEnumerator PlayerHeal()
    {
        playerUnit.Heal(5);

        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "You have regained health.";
        playerHeal.Play();
        playerHealing = true;
        playerAnimator.SetBool("isHealing", true);

        yield return new WaitForSeconds(2f);
        playerHealing = false;
        playerAnimator.SetBool("isHealing", false);

        yield return new WaitForSeconds (1f);

        state = BattleState.ENEMYONETURN;
        StartCoroutine(EnemyTurn());
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine (PlayerAttack());
    }

    public void OnDefenceButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerShield());
    }

    public void OnHealButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }

    public void Replay()
    {
        // Load the fight scene
        SceneManager.LoadScene("fight");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
