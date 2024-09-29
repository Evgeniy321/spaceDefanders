using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="entity", menuName = "SpaceDefance/entity")]
public class EntityDataSO : ScriptableObject
{
    public string enemyName;
    public GameObject resPref;
    public int resCount;
    public float maxHP;
    public float speed;
    public float rotateSpeed;
    public float patrolRange;
    public float folowRange;
    public float atackRange;
    public MissaleDataSO misale;
}
