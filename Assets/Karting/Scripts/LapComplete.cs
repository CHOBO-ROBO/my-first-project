using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapComplete : MonoBehaviour
{
  public GameObject LapCompleteTrig;
  public GameObject HalfLapTrig;

  public GameObject MinuteDisplay;
  public GameObject SecondDisplay;
  public GameObject MilliDisplay;

  public GameObject LapTimeBox;

  public GameObject LapCounter;
  public int LapsDone;

  void OnTriggerEnter () {
    LapsDone += 1;
    if (LapTimeManager.SecondCount <= 9) {
      SecondDisplay.GetComponent<TextMeshProUGUI>().SetText("0" + LapTimeManager.SecondCount + ".");
    }
  else
  {
   SecondDisplay.GetComponent<TextMeshProUGUI>().SetText( "" + LapTimeManager.SecondCount + "." );
  }
  if (LapTimeManager.MinuteCount <= 9) {
      MinuteDisplay.GetComponent<TextMeshProUGUI>().SetText("0" + LapTimeManager.MinuteCount + ".");
    }
  else
  {
  MinuteDisplay.GetComponent<TextMeshProUGUI>().SetText( "" + LapTimeManager.MinuteCount + "." );
  }
  MilliDisplay.GetComponent<TextMeshProUGUI> ().SetText ("" + LapTimeManager.MinuteCount);
  LapTimeManager.MinuteCount = 0;
  LapTimeManager.SecondCount = 0;
  LapTimeManager.MinuteCount = 0;
  LapCounter.GetComponent<TextMeshProUGUI> ().SetText ("" + LapsDone);
  HalfLapTrig.SetActive(true);
  LapCompleteTrig.SetActive(false);


   

    
    
  }
}
