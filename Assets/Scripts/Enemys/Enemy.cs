using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float progressAlongPath;  // Progresso do inimigo ao longo do caminho

    public int life;

    public List<Transform> paths;
    public int index = 0;

    public DataEnemy dataEnemy;

    protected void MoveAlongPath()
    {
        transform.position = Vector2.MoveTowards(transform.position, paths[index].position, dataEnemy.speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, paths[index].position) <  0.1f)
        {
            if (index < paths.Count - 1)
            {
                index++;
            }
            else
            {
                this.gameObject.SetActive(false);
            }
        }
    }

     protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            collision.gameObject.SetActive(false);
            life -= 100;
            if(life <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}