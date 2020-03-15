using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputerForGO3 : MonoBehaviour
{
    [SerializeField] Inputer inputer;

    void Start()
    {
        Subscribe();
    }

    private void PressS()
    {
        if (Input.GetKeyDown(KeyCode.S))
            Debug.Log("InputerForGO3 S");
    }

    private void Subscribe()
    {
        inputer.actions.Add(PressS);
    }
}
