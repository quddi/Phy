using UnityEngine;
using System.Linq;

public class BeseCurveInput : MonoBehaviour
{
    [SerializeField] private AnimationCurve _curve;

    public float MaxLevelHeight { get; private set; }

    public float[] InputFromCurve()
    {
        int count = SlidersController.MaxLevelsCount;

        float[] result = new float[count];

        for (int i = 0; i < count; i++)
            result[i] = _curve.Evaluate(i * (1.0f / count)) * SlidersController.MaxHeight;

        MaxLevelHeight = result.Max();

        return result;
    }
}
