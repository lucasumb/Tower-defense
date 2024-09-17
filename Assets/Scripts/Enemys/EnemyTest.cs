using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  EnemyTest : Enemy
{

    void Update()
    {
        progressAlongPath += dataEnemy.speed * Time.deltaTime;
        MoveAlongPath();
    }
}
