using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaboraShot : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.rotation = Quaternion.Euler(60, transform.root.eulerAngles.y, 0);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            transform.rotation = Quaternion.Euler(90, transform.root.eulerAngles.y, 0);
        }
    }
}