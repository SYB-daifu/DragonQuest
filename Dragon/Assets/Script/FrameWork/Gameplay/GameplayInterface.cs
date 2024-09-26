using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameplayInterface
{
    void Enable();
    void Disable();
    void OnShow();
    void OnHide();
    void Load();
    void UnLoad();
}
