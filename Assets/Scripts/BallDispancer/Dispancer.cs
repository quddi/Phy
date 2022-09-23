using UnityEngine;

public class Dispancer : MonoBehaviour
{
    [SerializeField] private Animator _pistonAnimator;

    private void Start()
    {
        _pistonAnimator.SetBool("Push", true);
    }
}
