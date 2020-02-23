using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float _startTime = 0;
    float _endTime = 1;
    bool _isStop = false;
    Action _actionWhenTimeIsOver;

    void Update()
    {
        _startTime += Time.deltaTime;

        if (_startTime >= _endTime && !_isStop)
        {
            _isStop = true;
            _actionWhenTimeIsOver();
        }
    }

    public void CallFunctionAfterSeconds(float endTime, Action action)
    {
        _startTime = 0;
        _endTime = endTime;
        _actionWhenTimeIsOver = action;
    }
}
