using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHome : MonoBehaviour
{
    [SerializeField] GameObject timer;
    [SerializeField] float delayTime = 2;

    [SerializeField] Transform targetTransform;
    [SerializeField] GameObject moverGO;

    void Start()
    {
        timer.GetComponent<Timer>().CallFunctionAfterSeconds(delayTime, () => {
            CallFunctionAfterSeconds();
        });
    }

    void Update()
    {
        MoveToWards();
    }
    
    private void CallFunctionAfterSeconds()
    {
        Debug.Log("Stop " + CalculatePoints.GetPoints());
        Destroy(timer);
    }

    private void MoveToWards()
    {
        Mover mover = moverGO.GetComponent<Mover>();
        mover.ParentMoveToWards(targetTransform);
    }
}