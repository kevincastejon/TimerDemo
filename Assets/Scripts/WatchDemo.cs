using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchDemo : MonoBehaviour
{
    [SerializeField] float _delayBetweenActions = 1f;
    float _nextActionTime;

    private void Update()
    {
        if (Time.time > _nextActionTime)
        {
            _nextActionTime = Time.time + _delayBetweenActions;
            Debug.Log("ACTION");
        }
    }
}
