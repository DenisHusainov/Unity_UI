using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Factorial : MonoBehaviour
{
    [SerializeField] private InputField field;
    [SerializeField] private Text text;
    private Button button;
    private uint fact { get; set; }
    

    private void Start()
    {
        button.onClick.AddListener(GetValue);
    }

    public void GetValue()
    {
        int numb = Convert.ToInt32(field.text);
        if ( numb > 33)
        {
            text.text = "Sorry man, you entered too large number!";
        }
        else
        {
            fact = 1;
            for (uint i = 1; i < numb+1; i++)
            {
                fact *= i;
            }
            text.text = Convert.ToString(fact);
        }
    }
    


}


