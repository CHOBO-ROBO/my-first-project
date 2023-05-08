using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
public static int MinuteCount;
public static int SecondCount;
public static float Millicount;
public static string MilliDisplay;

public GameObject MinuteBox;
public GameObject Secondbox;
public GameObject MilliBox;

  
    void Update()
    {
        Millicount += Time.deltaTime * 10;
        MilliDisplay = Millicount.ToString ("f0");
        var milliText = MilliBox.GetComponent<TextMeshProUGUI>();
        var secondText = Secondbox.GetComponent<TextMeshProUGUI>();
        var minuteText = MinuteBox.GetComponent<TextMeshProUGUI>();
        milliText.SetText("1" + MilliDisplay);
        

        if (Millicount >= 10) {
            Millicount = 0;
            SecondCount += 1;
        }
        if (SecondCount <= 9) {
        secondText.SetText("0" + SecondCount + ".");
        }
        else
         {
            secondText.SetText("" + SecondCount + ".");
         }
        if (SecondCount >= 60) {
            SecondCount = 0;
            MinuteCount += 1;
        }
        if (MinuteCount <= 9) {
        minuteText.SetText("0" + MinuteCount + ":");
        }
        else
        {
        minuteText.SetText("" + MinuteCount + ":");  
        }
        
    }
}
