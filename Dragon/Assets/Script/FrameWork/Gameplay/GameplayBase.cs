using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayBase : GameplayInterface
{

    private bool isShow = false;

    private bool isEnable = false;

    public void Disable()
    {
        if(isShow)
        {
            OnHide();
        }
        isEnable = false;
    }

    public void Enable()
    {
        if(!isShow)
        {
            OnShow();
        }
        isEnable = true;
    }

    public void Load(Func<bool> loadCallBack)
    {
        loadCallBack();
    }

    public void OnHide()
    {
        isShow = false;
    }

    public void OnShow()
    {
        isShow = true;
    }

    public void UnLoad()
    {

    }

}
