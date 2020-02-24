using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Action moveToWards;
    public Action onParentMoveToWards;

    public float Speed = 5;

    public bool dontMove = false;

    void Start() { }

    public void MoveTowards(Transform targetTransform)
    {
        if (dontMove) return;

        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, Time.deltaTime * Speed);
        moveToWards?.Invoke();
    }

    public void ParentMoveToWards(Transform targetTransform)
    {
        if (dontMove) return;

        transform.parent.position = Vector3.MoveTowards(transform.parent.position, targetTransform.position, Time.deltaTime * Speed);
        onParentMoveToWards?.Invoke();
    }
}