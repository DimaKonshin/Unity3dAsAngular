using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputerForMenu : MonoBehaviour
{
    [SerializeField] Inputer inputerForGameObjects;
    [SerializeField] Inputer inputerForMainMenu;
    [SerializeField] Inputer inputerForMenu;

    bool isMenuOpen = false;

    void Start()
    {
        Subscribe();
    }

    private void PressM()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isMenuOpen)
            {
                Debug.Log("Menu close");
                isMenuOpen = false;
                inputerForGameObjects.isControl = true;
                inputerForMainMenu.isControl = false;
            }
            else
            {
                Debug.Log("Menu show");
                isMenuOpen = true;
                inputerForGameObjects.isControl = false;
                inputerForMainMenu.isControl = true;
            }
        }
    }

    private void Subscribe()
    {
        inputerForMenu.actions.Add(PressM);
    }
}
