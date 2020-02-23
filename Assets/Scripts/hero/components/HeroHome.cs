using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHome : MonoBehaviour
{
    [SerializeField] GameObject timer;
    [SerializeField] float delayTime = 2;

    void Start()
    {
        InjectFn();
    }

    private void InjectFn()
    {
        timer.GetComponent<Timer>().CallFunctionAfterSeconds(delayTime, () => {
            CallFunctionAfterSeconds();
        });
    }
    
    private void CallFunctionAfterSeconds()
    {
        Debug.Log("Stop " + CalculatePoints.GetPoints());
        Destroy(timer);
    }
}
