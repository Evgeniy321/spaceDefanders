using UnityEngine;

public abstract class BaseState 
{
    protected EnemyMain main;
    protected EntityDataSO data;
    protected Transform target;
    public abstract void Enter();
    public abstract void Exit();
    public abstract void Logic();

}
