using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private GameObject _barrier;

    public void ChangeBarrierState()
    {
        _barrier.SetActive(!_barrier.activeSelf);
    }
}
