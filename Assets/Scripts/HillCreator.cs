using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillCreator : MonoBehaviour
{
    [SerializeField] private Vector3 _spawnPosition;

    [SerializeField] private GameObject _downHillPrefab;
    [SerializeField] private GameObject _upHillPrefab;
    [SerializeField] private DispancerGenerator _dispancerGenerator;

    private GameObject _downHill;
    private GameObject _upHill;

    public void Create(float[] levels, float maxHeight)
    {
        if (_downHill != null)
            Destroy(_downHill);
        if (_upHill != null)
            Destroy(_upHill);

        GameObject downHill = Instantiate(_downHillPrefab, _spawnPosition, Quaternion.identity);
        downHill.GetComponent<MeshGenerator>().GenerateNew(levels, maxHeight);
        _dispancerGenerator.SpawnPositionY = levels[0];
        GameObject upHill = Instantiate(_upHillPrefab, _spawnPosition, Quaternion.identity);
        upHill.GetComponent<MeshGenerator1>().GenerateNew(levels, maxHeight);
        upHill.transform.position = new Vector3(0, 3, 0);

        _downHill = downHill;
        _upHill = upHill;
    }
}
