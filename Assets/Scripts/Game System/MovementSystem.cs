using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : GameSystem
{
    public override void LogicRoutine()
    {
        base.LogicRoutine();
        Debug.Log($"MOVEMENT SYSTEM Logic Routine");
    }

    public override void PhysicsRoutine()
    {
        base.PhysicsRoutine();
        Debug.Log($"MOVEMENT SYSTEM Physics Routine");
    }
}
