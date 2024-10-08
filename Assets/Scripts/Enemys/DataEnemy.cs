using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemies/Enemy")]
public class DataEnemy : ScriptableObject
{
    public string enemyName;
    public int health;
    public float speed;
}
