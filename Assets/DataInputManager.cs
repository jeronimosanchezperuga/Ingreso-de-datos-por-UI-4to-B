using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInputManager : MonoBehaviour
{
    public Text txtUserInput; 

    public void ShowGreetings()
    {
        Debug.Log(int.Parse(txtUserInput.text) * 2);
    }
}
