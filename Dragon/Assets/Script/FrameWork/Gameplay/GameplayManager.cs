using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager
{
    private GameplayBase currentGameplay;

    private bool isLoading = false;

    public GameplayManager()
    {
        Stack<GameplayBase> stack = new Stack<GameplayBase>();
    }

    public bool ChangeGameplay(Func<bool> callback)
    {
        
        

        return true;
    }

    public bool PushGameplay(Func<bool> callback)
    {



        return true;
    }

    public bool PopGameplay(Func<bool> callback)
    {



        return true;
    }
}
