using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Hariel : Unit
{
    public Hariel(float damage, float fireRate, float range, float cost) : base(damage, fireRate, range, cost)
    {
    }

    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 3;
        range = 3;
        damage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
