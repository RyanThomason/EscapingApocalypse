using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScrewdriver : MonoBehaviour
{
    public GameObject screwDriver;
    public GameObject floatingText;

    public void pickup()
    {
        Destroy(screwDriver);
        Instantiate(floatingText);
    }
}
