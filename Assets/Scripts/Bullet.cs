using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform destination;
    public float speedBullet;

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
        transform.position = Vector2.MoveTowards(transform.position, destination.position, speedBullet * Time.deltaTime);

        if (Vector2.Distance(transform.position, destination.position) < 0.001f)
        {
            this.gameObject.SetActive(false);
        }
    }
}
