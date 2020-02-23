using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    [SerializeField] GameObject timerGO;
    [SerializeField] float delayTime = 2;

    Timer timer;

    void Start()
    {
        timer = timerGO.GetComponent<Timer>();
        CallFunctionAfterSeconds();
    }

    private void CallFunctionAfterSeconds()
    {
        timer.CallFunctionAfterSeconds(delayTime, () => {
            Debug.Log("stars component " + CalculatePoints.GetPoints());
            CallFunctionAfterSeconds();
        });
    }
}
