using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class  EnemyTest : Enemy
{

    public EnemyTest(int life, float speed) : base(life, speed)
    {
    }

    void Update()
    {
        progressAlongPath += speed * Time.deltaTime;
        MoveAlongPath();
    }
}
