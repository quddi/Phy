using UnityEngine;

public abstract class HillMeshGenerator : MonoBehaviour
{
    protected float[] _levels;

    protected const float HillLength = 0.88f;
    protected float _maxHeight;

    protected Mesh _mesh;

    protected abstract void CreateShape();

    protected abstract void UpdateMesh();

    public void GenerateNew(float[] newLevels, float maxHeight)
    {
        _levels = newLevels;
        _maxHeight = maxHeight;
        Generate();
    }

    private void Generate()
    {
        _mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = _mesh;
        GetComponent<MeshCollider>().sharedMesh = _mesh;
        CreateShape();
        UpdateMesh();
    }
}
