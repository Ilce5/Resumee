using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameInput : MonoBehaviour
{
    public Text username;
    public Text input;
    public GameObject error;
    private string check;

    public void TransferUsername()
    {
        check = input.text;
        if (check.Length > 9)
        {
            error.SetActive(true);
        }else if(check.Length < 1)
        {

        }
        else
            username.text = check;
    }

}
