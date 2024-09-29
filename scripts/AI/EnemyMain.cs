using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    [SerializeField] private EntityDataSO data;
    [SerializeField] private Transform player;
    [SerializeField] private Transform firePos;

    private Patrol patrol;
    public Patrol PatrolState => patrol;

    private Attack attack;
    public Attack AttackState => attack;

    private Backup backup;
    public Backup BackupState => backup;

    private Folow folow;
    public Folow FolowState => folow;

    private Die die;
    public Die DieState => die;

    private BaseState curState;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        patrol = new Patrol(this, data, player);
        attack = new Attack(this, data, player, firePos);
        backup = new Backup(this, data, player);
        folow = new Folow(this, data, player);
        ChangeState(patrol);

    }

    public void ChangeState(BaseState newState)
    {
        if(curState != null)
        {
            curState.Exit();
        }
        curState = newState;
        curState.Enter();
        Debug.Log(curState);
    }
    // Update is called once per frame
    void Update()
    {
        if(curState != null)
        {
            curState.Logic();
        }
    }
    public void MoveForward(Vector3 pos)
    {
        transform.LookAt(pos);
        transform.position = Vector3.MoveTowards(transform.position, pos, data.speed);
    }

    
}
