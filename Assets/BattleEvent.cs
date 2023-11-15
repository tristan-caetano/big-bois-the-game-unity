using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleEvent : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemy;

    public Transform enemyLoc;
    public Transform playerLoc;

    Unit playerUnit;
    Unit enemyUnit;

    public Text dialogueText;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {

        state = BattleState.START;
        SetupBattle();
        
    }

    void SetupBattle(){
        
        GameObject playerGO = Instantiate(player, playerLoc);
        playerUnit = playerGO.getComponent<Unit>();

        GameObject enemyGO = Instantiate(enemy, enemyLoc);
        enemyUnit = enemyGO.getComponent<Unit>();

        dialogueText.text = "Oh gorsh " + enemyUnit.unitName + " has appeared!";

    }
}
