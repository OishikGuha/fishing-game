using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPlaceholder : MonoBehaviour
{
    public GameManager gm;

    private string colorName;

    private string player = "Player_";

    public Text placeHolderText;

    private void Update()
    {
        colorName = gm.goal.color;

        ColorNamer();

        placeHolderText.text = string.Format("The {0} color can pass through", colorName);
    }

    public void ColorNamer()
    {
        if (colorName == player + "g")
        {
            colorName = "Green";
        }
        else if (colorName == player + "c")
        {
            colorName = "Cyan";
        }
    }
}
