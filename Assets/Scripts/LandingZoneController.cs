// LandingZoneController.cs
// CENG 454 - HW2 Midterm
// Author : Beyza Nur Elitok | Student ID: 210444043

using UnityEngine;

public class LandingZoneController : MonoBehaviour
{
    [SerializeField] private FlightExamManager examManager;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        examManager.TryLand();
    }
}