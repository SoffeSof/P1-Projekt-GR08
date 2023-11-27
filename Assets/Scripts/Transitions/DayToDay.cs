using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayToDay : MonoBehaviour
{
    public Animator DayTransitionAnim;
    public GameObject DayToDayCanvas;
    public TMP_Text dayDisplay;
    public int dayCount;
    public AnimationClip DayEnd;

    public void NextDay()
    {
        StartCoroutine(NextDaySequence());
    }

    IEnumerator NextDaySequence()
    {
        DayToDayCanvas.SetActive(true);

        dayCount++;

        dayDisplay.text = "Day " + dayCount.ToString();

        DayTransitionAnim.SetTrigger("DayStart");

        yield return new WaitForSeconds(4);

        DayTransitionAnim.SetTrigger("DayEnd");

        yield return new WaitForSeconds(DayEnd.length);


        DayToDayCanvas.SetActive(false);
    }

}
