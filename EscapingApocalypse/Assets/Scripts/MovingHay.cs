using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHay : MonoBehaviour
{
    public GameObject hayBales;
    
    public void moveHay()
    {
        hayBales.transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z - 0.8f);
    }
}
