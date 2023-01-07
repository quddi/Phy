using UnityEngine;

public class Dispancer : MonoBehaviour
{
    [SerializeField] private Transform _ball;
    private void Start()
    {
        _ball.parent = null;
    }
}
