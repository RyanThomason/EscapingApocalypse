using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LockController : MonoBehaviour
{
    private string input;
    public GameObject Canvas;
    public GameObject inputField;
    
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("/House/Door/LockMechanism/Canvas");
        Canvas.SetActive(false);
    }

    public void openInput()
    {
        Canvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public void getInput()
    {
        string input = inputField.GetComponent<TMP_InputField>().text;
        Debug.Log(input);
        int intInput;
        int.TryParse(input, out intInput);
        if(intInput == 2354)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}