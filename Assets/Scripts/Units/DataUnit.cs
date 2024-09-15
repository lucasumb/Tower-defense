using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Unit")]
public class DataUnit : ScriptableObject
{
    public string unitName;
    public float damage;
    public float fireRate;
    public float range;
    public float cost;

    public GameObject prefabBullet;
}
