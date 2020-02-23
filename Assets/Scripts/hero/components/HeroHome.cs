using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHome : MonoBehaviour
{
    [SerializeField] GameObject timer;
    [SerializeField] float delayTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        InjectFn();
    }

    private void InjectFn()
    {
        //Instantiate(timer).GetComponent<Timer>().CallFunctionAfterSeconds(delayTime, () => {
        //    Debug.Log("Stop");
        //});
        timer.GetComponent<Timer>().CallFunctionAfterSeconds(delayTime, () => {
            Debug.Log("Stop");
            Destroy(timer);
        });
    }
}
