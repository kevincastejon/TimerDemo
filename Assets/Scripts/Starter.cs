using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _startText;

    public void StartIt()
    {
        _startText.text = "Paul starts by putting a first bread into the hoven.\nThen he calculates when the bread will be baked by adding the <b>baking duration (2s)</b> to the <b>current time ("+Time.time.ToString("F4")+"s)</b>";
    }
}
