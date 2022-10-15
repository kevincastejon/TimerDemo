using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTimeUpdater : MonoBehaviour
{
    TextMeshProUGUI _currentTimeText;
    private void Awake()
    {
        _currentTimeText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _currentTimeText.text = "Current Time (Time.time) : " + Time.time.ToString("F4")+"s";
    }
}
