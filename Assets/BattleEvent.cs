using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleEvent : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemy;

    public Transform enemyLoc;
    public Transform playerLoc;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {

        state = BattleState.START;
        SetupBattle();
        
    }

    void SetupBattle(){
        
        Instantiate(player, playerLoc);
        Instantiate(enemy, enemyLoc);

    }
}
