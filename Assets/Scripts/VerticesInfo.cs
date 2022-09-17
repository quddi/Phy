using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticesInfo
{
    public int PreviousUpperID { get; private set; }

    public int PreviousLowerID { get; private set; }

    public int CurrentUpperID { get; private set; }

    public int CurrentLowerID { get; private set; }

    public VerticesInfo(VerticesInfo previousVertices)
    {
        PreviousUpperID = previousVertices.PreviousUpperID + 4;
        PreviousLowerID = previousVertices.PreviousLowerID + 4;
        CurrentUpperID = previousVertices.CurrentUpperID + 4;
        CurrentLowerID = previousVertices.CurrentLowerID + 4;
    }

    public VerticesInfo(int previousUpperID, int previousLowerID, int currentUpperID, int currentLowerID)
    {
        PreviousUpperID = previousUpperID;
        PreviousLowerID = previousLowerID;
        CurrentUpperID = currentUpperID;
        CurrentLowerID = currentLowerID;
    }
}
