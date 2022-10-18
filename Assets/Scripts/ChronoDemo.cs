using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoDemo : MonoBehaviour
{
    [SerializeField] float _delayBetweenActions = 1f;
    float _chrono;

    private void Update()
    {
        _chrono += Time.deltaTime;
        if (_chrono > _delayBetweenActions)
        {
            _chrono = 0f;
            Debug.Log("ACTION");
        }
    }
}
