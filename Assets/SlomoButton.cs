using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SlomoButton : MonoBehaviour
{
    private Button button;
    public static int slomos;
    public TextMeshProUGUI slomosText;
    void Start()
    {
        button = GetComponent<Button>();
        button.interactable = false;
        slomos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        slomosText.text = slomos.ToString(); 
        if(slomos <= 0)
            button.interactable = false;
        else
            button.interactable = true;

        if (button.interactable == false)
        {
            Color newColor = button.image.color;
            newColor.a = 0.5f;
            button.image.color = newColor;
        }
        else
        {
            Color newColor = button.image.color;
            newColor.a = 1f;
            button.image.color = newColor;

        }
            


    }

    public void incSlomo()
    {
        slomos++;
    }
    public void decSlomo()
    {
        slomos--;
    }
}
