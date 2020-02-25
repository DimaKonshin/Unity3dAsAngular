using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHome : MonoBehaviour
{
    [SerializeField] Transform targetTransform;

    [SerializeField] GameObject timer;
    [SerializeField] float delayTime = 2;

    [SerializeField] GameObject moverGO;
    Mover mover;

    [SerializeField] GameObject distancerGO;
    [SerializeField] float targetDistance = 1f;
    Distancer distancer;

    void Start()
    {
        mover = moverGO.GetComponent<Mover>();

        timer.GetComponent<Timer>().CallFunctionAfterSeconds(delayTime, () => {
            CallFunctionAfterSeconds();
        });

        InitializeDistancer();
    }

    private void CallFunctionAfterSeconds()
    {
        Debug.Log("Stop " + CalculatePoints.GetPoints());
        Destroy(timer);
    }

    private void InitializeDistancer()
    {
        //GameObject go = Instantiate(distancerGO); // use clone Distancer
        //go.transform.SetParent(gameObject.transform);
        distancer = distancerGO.GetComponent<Distancer>(); // use existing Distancer
        distancer.Constructor(targetTransform, targetDistance);
        distancer.OnDistanceMore += mover.ParentMoveToWards;
    }
}