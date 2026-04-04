// FlightExamManager.cs
// CENG 454 - HW2 Midterm
// Author : Beyza Nur Elitok | Student ID: 210444043

using UnityEngine;
using TMPro;

public class FlightExamManager : MonoBehaviour
{
    [SerializeField] private TMP_Text hudWarningText;

    //private bool inDangerZone = false;
    private bool hasTakenOff = false;
    private bool threatCleared = false;
    private bool missionComplete = false;

    public void TakeOff()
    {
        if (hasTakenOff) return;
        hasTakenOff = true;
        hudWarningText.text = "Takeoff! Find the danger zone.";
        hudWarningText.color = Color.white;
    }

    public void EnterDangerZone()
    {
        //inDangerZone = true;
        hudWarningText.text = "Entered a Dangerous Zone!";
        hudWarningText.color = Color.red;
    }

    public void ExitDangerZone()
    {
        //inDangerZone = false;
        threatCleared = true;
        hudWarningText.text = "Zone Cleared! Find a safe landing.";
        hudWarningText.color = Color.green;
    }

    //public void ClearHUD()
    //{
    //    hudWarningText.text = "";
    //}

    //public bool IsThreatCleared()
    //{
    //    return threatCleared;
    //}

    public void OnMissileHit()
    {
        threatCleared = false;
        //inDangerZone = false;
        hudWarningText.text = "Hit! Return to danger zone...";
        hudWarningText.color = Color.yellow;
    }
    public void TryLand()
    {
        if (!hasTakenOff)
        {
            hudWarningText.text = "You must take off first!";
            hudWarningText.color = Color.yellow;
            return;
        }

        if (!threatCleared)
        {
            hudWarningText.text = "Clear the threat first!";
            hudWarningText.color = Color.yellow;
            return;
        }

        if (missionComplete) return;

        missionComplete = true;
        hudWarningText.text = "Mission Complete! Safe landing!";
        hudWarningText.color = Color.cyan;
    }

    public bool IsThreatCleared() => threatCleared;
}