using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : BaseState
{
    private float timer;
    private Transform firePos;
    public Attack(EnemyMain main, EntityDataSO data, Transform target, Transform firePos) 
    { 
        this.main = main;
        this.data = data;
        this.target = target;
        this.firePos = firePos;
    }
    public override void Enter()
    {

    }

    public override void Exit()
    {
        timer = 0;
    }
    private void Shoot(Vector3 pos)
    {
        if(timer > 1 / data.misale.attackRate)
        {
            MonoBehaviour.Instantiate(data.misale.pref, firePos.position, firePos.rotation).Setup(firePos);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    public override void Logic()
    {
        main.transform.LookAt(this.target);
        Shoot(target.position);
        if (Vector3.Distance(main.transform.position, target.position) > data.atackRange)
        {
            main.ChangeState(main.FolowState);
        }
    }


   
}
