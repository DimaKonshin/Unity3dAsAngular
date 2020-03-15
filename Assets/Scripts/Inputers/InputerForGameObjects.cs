using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputerForGameObjects : MonoBehaviour
{
    [SerializeField] Inputer inputer;

    void Start()
    {
        Subscribe();
    }

    private void PressSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("InputerForGameObjects space");
    }

    private void Subscribe()
    {
        inputer.actions.Add(PressSpace);
    }
}
