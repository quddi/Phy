using TMPro;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SlidersController : MonoBehaviour
{
    [SerializeField] private GameObject[] _slidersObjects;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private float _maxHeight;

    private Slider[] _sliders;
    private int _count;

    public float[] GetSlidersValues => _sliders.Take(_count).Select(x => x.value * _maxHeight).ToArray();

    private void Awake()
    {
        _count = _slidersObjects.Length;
        _sliders = _slidersObjects.Select(x => x.GetComponent<Slider>()).ToArray();
    }

    public void OnSlidersCountChange(string input)
    {
        int count = int.Parse(_inputField.text);
        count = Mathf.Clamp(count, 10, 99);

        ChangeCount(count);
    }

    public void ChangeCount(int count)
    {
        if (_count > count)
            for (int i = count; i < _count; i++)
                _slidersObjects[i].SetActive(false);

        else if (_count < count)
            for (int i = _count; i < count; i++)
                _slidersObjects[i].SetActive(true);

        _count = count;
    }
}
