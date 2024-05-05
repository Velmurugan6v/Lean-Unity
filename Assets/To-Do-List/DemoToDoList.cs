using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DemoToDoList : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private string content;
    // Start is called before the first frame update
    
    public void OnValueChange()
    {
        content = inputField.text;
    }

    public void TypeEnd()
    {
        print("End");
    }

    public void TypeDeselect()
    {
        print("Deselect");
    }

    public void Select()
    {
        print("Select");
    }
}
