using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpHillLifter : MonoBehaviour
{
    public void Lift()
    {
        GameObject upHill = GameObject.Find("MeshGenerator 1(Clone)");

        if (upHill == null)
            return;



        upHill.transform.position = new Vector3(upHill.transform.position.x, upHill.transform.position.y + 10, upHill.transform.position.z);
    }
}
