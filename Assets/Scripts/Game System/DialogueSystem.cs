using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : GameSystem
{
    public override void LogicRoutine()
    {
        base.LogicRoutine();
        Debug.Log($"DIALOGUE SYSTEM Logic Routine");
    }

    public override void PhysicsRoutine()
    {
        base.PhysicsRoutine();
        Debug.Log($"DIALOGUE SYSTEM Physics Routine");
    }
}
