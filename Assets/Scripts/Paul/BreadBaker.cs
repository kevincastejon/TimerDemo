using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BreadBaker : MonoBehaviour
{
    [SerializeField] Rigidbody2D _breadPrefab;
    [SerializeField] float _bakeDuration;
    [SerializeField] TextMeshProUGUI _bakeEndingTimeText;
    [SerializeField] GameObject _waitPanel;
    [SerializeField] GameObject _doActionPanel;
    [SerializeField] Slider _slider;
    float _bakeEndingTime;
    Rigidbody2D _bakingBread;
    SpriteRenderer _bakingBreadRenderer;


    private void Start()
    {
        Time.timeScale = 0f;
        _bakeEndingTime = Time.time + _bakeDuration;
        PlaceNewBread();
    }

    void Update()
    {
        if (Time.time >= _bakeEndingTime)
        {
            _bakeEndingTime = Time.time + _bakeDuration;
            PlaceNewBread();
        }
        _slider.SetValueWithoutNotify(Time.timeScale);
        if (_bakingBreadRenderer)
        {
            float progress = (_bakeEndingTime - Time.time) / _bakeDuration;
            _bakingBreadRenderer.color = new Color(1f, 1f, progress, 1f);
        }
    }

    void PlaceNewBread()
    {
        _bakeEndingTimeText.text = "Bake Ending Time : " + _bakeEndingTime.ToString("F4") + "s";
        if (_bakingBread)
        {
            //_bakingBread.transform.position = new Vector3(_bakingBreadRenderer.transform.position.x, _bakingBreadRenderer.transform.position.y - 1f, -1f);
            _bakingBread.transform.position += Vector3.down/100f;
            _bakingBread.transform.position -= Vector3.forward;
            _bakingBread.bodyType = RigidbodyType2D.Dynamic;
            _bakingBread.AddForce(new Vector2(Random.Range(-2f, 2f), -10f), ForceMode2D.Impulse);
            _waitPanel.SetActive(false);
            _doActionPanel.SetActive(true);
        }
        _bakingBread = Instantiate(_breadPrefab, transform.position, Quaternion.identity);
        _bakingBreadRenderer = _bakingBread.GetComponentInChildren<SpriteRenderer>();
        Time.timeScale = 0f;

    }
}
