using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    // atributos
    public float damage;
    public float fireRate;
    public float range;
    public float cost;

    public float cooldownFire;

    public LayerMask enemyLayer;

    protected Unit(float damage, float fireRate, float range, float cost)
    {
        this.damage = damage;
        this.fireRate = fireRate;
        this.range = range;
        this.cost = cost;
    }

    public abstract void Attack();
    public virtual void SpawnBullet(Transform destination) { }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
