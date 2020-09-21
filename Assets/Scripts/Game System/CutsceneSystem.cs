using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSystem : GameSystem
{
    public override void LogicRoutine()
    {
        base.LogicRoutine();
        Debug.Log($"CUTSCENE SYSTEM Logic Routine");
    }

    public override void PhysicsRoutine()
    {
        base.PhysicsRoutine();
        Debug.Log($"CUTSCENE SYSTEM Physics Routine");
    }
}
