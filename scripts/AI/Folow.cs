using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folow : BaseState
{
    public Folow(EnemyMain main, EntityDataSO data, Transform target)
    {
        this.main = main;
        this.data = data;
        this.target = target;
    }
    public override void Enter()
    {

    }

    public override void Exit()
    {

    }

    public override void Logic()
    {
        //main.MoveForward(target.position);
        if (Vector3.Distance(main.transform.position, target.position) < data.folowRange)
        {
            main.ChangeState(main.PatrolState);
        }
        if (Vector3.Distance(main.transform.position, target.position) <= data.atackRange)
        {
            main.ChangeState(main.AttackState);
        }
    }


}
