using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDrawer : MonoBehaviour
{
    public GameObject drawer;

    public void OpenDrawer()
    {
        drawer.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.41f);    
    }

}
