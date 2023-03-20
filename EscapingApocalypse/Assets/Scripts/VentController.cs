using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VentController : MonoBehaviour
{
    public void OpenVent(GameObject obj)
    {
        PlayerManager manager = obj.GetComponent<PlayerManager>();
        if(manager)
        {
            if(manager.screwDriver > 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
