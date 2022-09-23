using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsAdapter : MonoBehaviour
{
    [SerializeField] private BeseCurveInput _beseCurve;
    [SerializeField] private SlidersController _slidersController;
    [SerializeField] private HillCreator _hillCreator;

    public void GenerateBySliders()
    {
        _hillCreator.Create(_slidersController.GetSlidersValues, SlidersController.MaxHeight);
    }

    public void GenerateByCurve()
    {
        _hillCreator.Create(_beseCurve.InputFromCurve(), _beseCurve.MaxLevelHeight);
    }
}
