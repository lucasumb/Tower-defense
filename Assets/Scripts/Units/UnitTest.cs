using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class UnitTest : Unit
{
    [SerializeField]
    private GameObject prefabBullet;

    public UnitTest(float damage, float fireRate, float range, float cost) : base(damage, fireRate, range, cost)
    {
    }

    // corrigir a parte do tiro (spawn)
    public override void Attack()
    {
        cooldownFire += Time.deltaTime;
        Collider2D hit = Physics2D.OverlapCircle(transform.position, range, enemyLayer);

        if (hit != null && cooldownFire > fireRate)
        {
            Debug.Log("Atira");
            cooldownFire = 0;

            //SpawnBullet(transform);
        }
    }

    public override void SpawnBullet(Transform destination)
    {
        Instantiate(prefabBullet);
    }

    //
    void Start()
    {
        // não ficar em tempo de recarga no primeiro tiro ao entrar em campo
        cooldownFire = fireRate;
    }

    void Update()
    {
        Attack();
    }
}
