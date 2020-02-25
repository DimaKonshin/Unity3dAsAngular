using System;
using UnityEngine;

public class Distancer : MonoBehaviour
{
    [SerializeField] Transform _targetTransform;
    [SerializeField] float _distance = 0f;
    public Action<Transform> OnDistanceMore;
    public Action<Transform> OnDistanceLess;
    public Action<Transform> OnDistanceEqual;

    public void Constructor(Transform targetTransform, float distance)
    {
        _targetTransform = targetTransform;
        _distance = distance;
    }

    void Update()
    {
        if (_targetTransform == null)
        {
            return;
        }

        if (Vector3.Distance(transform.parent.position, _targetTransform.position) > _distance)
        {
            OnDistanceMore?.Invoke(_targetTransform);
        }
        else if (Vector3.Distance(transform.parent.position, _targetTransform.position) < _distance)
        {
            OnDistanceLess?.Invoke(_targetTransform);
        }
        else if (Vector3.Distance(transform.parent.position, _targetTransform.position) == _distance)
        {
            OnDistanceEqual?.Invoke(_targetTransform);
        }
    }
}