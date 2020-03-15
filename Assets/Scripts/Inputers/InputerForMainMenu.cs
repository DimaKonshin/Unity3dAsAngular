using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputerForMainMenu : MonoBehaviour
{
    [SerializeField] Inputer inputer;

    void Start()
    {
        Subscribe();
    }

    private void PressSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("InputerForMainMenu space");
    }

    private void PressKButton()
    {
        if (Input.GetKeyDown(KeyCode.K))
            Debug.Log("InputerForMainMenu K");
    }

    private void Subscribe()
    {
        inputer.actions.Add(PressKButton);
        inputer.actions.Add(PressSpace);
    }
}
