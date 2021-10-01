using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionExample 
{
    public static void SetPositionXZ(this Transform transform, float x, float z)
    {
        var newPosition = new Vector3(x, transform.position.y, z);
        transform.position = newPosition;
    }
}
