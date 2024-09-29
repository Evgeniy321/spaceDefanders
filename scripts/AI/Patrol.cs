using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : BaseState
{
    private Transform defPos;
    private Vector3 newPos;
    public Patrol(EnemyMain main, EntityDataSO data, Transform target)
    {
        this.main = main;
        this.data = data;
        this.target = target;
        defPos = this.main.transform;
    }
    public override void Enter()
    {
        GenNewPoint();
    }
    private void GenNewPoint()
    {
        newPos = defPos.position + new Vector3(Random.Range(-data.patrolRange/2, data.patrolRange/2), Random.Range(-data.patrolRange / 2, data.patrolRange / 2), 0);
    }

    public override void Exit()
    {

    }

    public override void Logic()
    {
        if(Vector3.Distance(main.transform.position, target.position) <= data.folowRange)
        {
            main.ChangeState(main.FolowState);
        }
        //main.MoveForward(newPos);
        if (Vector3.Distance(main.transform.position, newPos) < 0.1f)
        {
            main.ChangeState(main.PatrolState);
        }

    }


}
