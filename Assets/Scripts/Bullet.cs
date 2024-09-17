using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform destination;
    public float speedBullet;
    public float timeBullet;

    public Bullet(Transform destination)
    {
        this.destination = destination;
    }

    // Update is called once per frame
    void Update()
    {
        MovementBullet();
    }

    void MovementBullet()
    {
        timeBullet += Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, destination.position, speedBullet * Time.deltaTime);


        //Alterar para o alcance
        if (timeBullet  > 10)
        {
            this.gameObject.SetActive(false);
        }
    }

}
