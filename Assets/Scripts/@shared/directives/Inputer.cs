using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputer : MonoBehaviour
{
    public List<Action> actions = new List<Action>();

    public bool isControl = true;

    void Update()
    {
        if (!isControl) return;

        foreach (var action in actions)
        {
            action?.Invoke();
        }
    }
}
