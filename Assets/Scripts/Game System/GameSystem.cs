using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameSystem : MonoBehaviour, IGameSystem
{
    protected GameController gameController;

    public GameController GameController { get; set; }

    public virtual void LogicRoutine()
    {

    }

    public virtual void PhysicsRoutine()
    {

    }

    protected virtual void Awake()
    {
        gameController = GetComponentInParent<GameController>();
    }
}
