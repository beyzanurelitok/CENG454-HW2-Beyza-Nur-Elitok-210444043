// FlightExamManager.cs
// CENG 454 - HW2 Midterm
// Author : Beyza Nur Elitok | Student ID: 210444043

using UnityEngine;
using TMPro;

public class FlightExamManager : MonoBehaviour
{
    [SerializeField] private TMP_Text hudWarningText;

    private bool inDangerZone = false;
    private bool threatCleared = false;
    private bool missionComplete = false;

    public void EnterDangerZone()
    {
        inDangerZone = true;
        hudWarningText.text = "Entered a Dangerous Zone!";
        hudWarningText.color = Color.red;
    }

    public void ExitDangerZone()
    {
        inDangerZone = false;
        threatCleared = true;
        hudWarningText.text = "Zone Cleared! Find a safe landing.";
        hudWarningText.color = Color.green;
    }

    public void ClearHUD()
    {
        hudWarningText.text = "";
    }

    public bool IsThreatCleared()
    {
        return threatCleared;
    }
}