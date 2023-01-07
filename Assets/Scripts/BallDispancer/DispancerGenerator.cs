using UnityEngine;

public class DispancerGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _dispancerPrefab;
    [SerializeField] private float _spawnPositionX;
    [SerializeField] private float _spawnPositionZ;
    [SerializeField] private float _deltaY;

    private float _spawnPositionY;
    public float SpawnPositionY 
    { 
        get 
        { 
            return _spawnPositionY; 
        } 
        set 
        { 
            _spawnPositionY = value - _deltaY; 
        } 
    }

    private GameObject _spawnedDispancer;

    public void GenerateDispancer()
    {
        if (_spawnedDispancer != null)
            Destroy(_spawnedDispancer);

        _spawnedDispancer = Instantiate(_dispancerPrefab, 
                                        new Vector3(_spawnPositionX, 
                                                    _spawnPositionY, 
                                                    _spawnPositionZ), 
                                        Quaternion.identity);
    }
}
