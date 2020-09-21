using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameFactory
{
    public static void Create(GameController gameController)
    {
        gameController.InstantiateSystems<CutsceneSystem>();
        gameController.InstantiateSystems<DialogueSystem>();
        gameController.InstantiateSystems<MovementSystem>();
        
    }
}
