using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputerForGO2 : MonoBehaviour
{
    [SerializeField] Inputer inputer;

    void Start()
    {
        Subscribe();
    }

    private void PressA()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Debug.Log("InputerForGO2 A");
    }

    private void Subscribe()
    {
        inputer.actions.Add(PressA);
    }
}
