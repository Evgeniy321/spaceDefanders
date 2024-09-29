using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CreateAssetMenu(fileName ="missale", menuName = "SpaceDefance/missale")]
public class MissaleDataSO : ScriptableObject
{
    public Bullet pref;
    public float dmg;
    public float lifeTime;
    public float speed;
    public float StartForce;
    public float attackRate;
    public float energyReq;
    public bool isAutoTarget;
}
