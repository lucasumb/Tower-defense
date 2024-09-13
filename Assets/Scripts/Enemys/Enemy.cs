using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float progressAlongPath;  // Progresso do inimigo ao longo do caminho

    public int life;
    public float speed;

    public List<Transform> paths = new List<Transform>();
    public int index = 0;

    protected Enemy(int life, float speed)
    {
        this.life = life;
        this.speed = speed;
    }

    protected void MoveAlongPath()
    {
        transform.position = Vector2.MoveTowards(transform.position, paths[index].position, speed * Time.deltaTime);

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
}