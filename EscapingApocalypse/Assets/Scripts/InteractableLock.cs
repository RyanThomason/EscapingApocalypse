using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableLock : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("/House/Door/LockMechanism/Canvas");
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player in range");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Player not in range");
        }
    }
}
