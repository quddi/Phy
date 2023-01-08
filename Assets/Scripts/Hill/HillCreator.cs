using UnityEngine;
using UnityEngine.UI;

public class HillCreator : MonoBehaviour
{
    [SerializeField] private Vector3 _spawnPosition;

    [SerializeField] private GameObject _downHillPrefab;
    [SerializeField] private GameObject _upHillPrefab;
    [SerializeField] private DispancerGenerator _dispancerGenerator;
    [SerializeField] private Slider _heightSlider;

    private GameObject _downHill;
    private GameObject _upHill;

    private float _maxHeight;

    public void Create(float[] levels, float maxHeight)
    {
        if (_downHill != null)
            Destroy(_downHill);
        if (_upHill != null)
            Destroy(_upHill);

        GameObject downHill = Instantiate(_downHillPrefab, _spawnPosition, Quaternion.identity);
        downHill.GetComponent<HillMeshGenerator>().GenerateNew(levels, maxHeight);
        _dispancerGenerator.SpawnPositionY = levels[0];

        GameObject upHill = Instantiate(_upHillPrefab, _spawnPosition, Quaternion.identity);
        upHill.GetComponent<HillMeshGenerator>().GenerateNew(levels, maxHeight);
        upHill.transform.position = new Vector3(0, maxHeight, 0);

        _downHill = downHill;
        _upHill = upHill;

        _maxHeight = maxHeight;
    }

    private void Update()
    {
        if (_upHill != null)
            _upHill.transform.position = new Vector3(0, _maxHeight + _heightSlider.value, 0);
    }
}
