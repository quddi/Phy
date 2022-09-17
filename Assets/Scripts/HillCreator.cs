using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillCreator : MonoBehaviour
{
    [SerializeField] private Vector3 _spawnPosition;

    [SerializeField] private GameObject _hillPrefab;

    private GameObject _hill;

    public void Create(float[] levels)
    {
        if (_hill != null)
            Destroy(_hill);

        GameObject currentHill = Instantiate(_hillPrefab, _spawnPosition, Quaternion.identity);
        currentHill.GetComponent<MeshGenerator>().GenerateNew(levels);

        _hill = currentHill;
    }
}
