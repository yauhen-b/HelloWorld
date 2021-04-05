using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public RedEnemy enemy;
    public RedPlayer player;
    
    private int pA, pH, pD, eA, eH, eP;
    private string pName, eName;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //player attacks
            PlayerAttacks();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            //enemy attacks
            EnemyAttacks();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            //restart
            Restart();
        }
    }

    private void Initialize()
    {
        pA = player.attack;
        pH = player.health;
        pD = player.defence;
        pName = player.name;
        eA = enemy.attack;
        eH = enemy.health;
        eP = enemy.pierce;
        eName = enemy.name;
        print(message:$"player stats: attack={pA} health={pH} defence={pD} name={pName}\n" +
                      $"enemy stats: attack={eA} health={eH} pierce={eP} name={eName}\n");
    }

    private void Restart()
    {
        player.attack = pA;
        player.health = pH;
        player.defence = pD;
        player.name = pName;
        enemy.attack = eA;
        enemy.health = eH;
        enemy.pierce = eP;
        enemy.name = eName;
        print(message:$"player stats: attack={pA} health={pH} defence={pD} name={pName}\n" +
                      $"enemy stats: attack={eA} health={eH} pierce={eP} name={eName}\n");
    }

    private void PlayerAttacks()
    {
        enemy.health -= player.attack;
        print(message:$"{player.name} attacks {enemy.name} for {player.attack} damage," +
                      $"{enemy.health} remains\n");
    }

    private void EnemyAttacks()
    {
        int damage = enemy.attack + enemy.pierce - player.defence;
        player.health -= damage;
        print(message:$"{enemy.name} attacks {player.name} for {damage} damage," +
                      $"{player.health} remains\n");
    }
}
