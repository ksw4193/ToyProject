using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBlade : MonoBehaviour
{
    public bool rightBlade;
    void Update()
    {     
        transform.rotation *= Quaternion.Euler(0, (rightBlade ? -1500 : 1500) * Time.deltaTime, 0);
    }
}
