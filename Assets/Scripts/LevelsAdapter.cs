using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsAdapter : MonoBehaviour
{
    [SerializeField] private SlidersController _slidersController;
    [SerializeField] private HillCreator _hillCreator;

    public void GenerateNewMesh()
    {
        _hillCreator.Create(_slidersController.GetSlidersValues);
    }
}
