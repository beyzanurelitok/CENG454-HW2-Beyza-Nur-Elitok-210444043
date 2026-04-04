// TakeoffZoneController.cs
// CENG 454 - HW2 Midterm
// Author : Beyza Nur Elitok | Student ID: 210444043

using UnityEngine;

public class TakeoffZoneController : MonoBehaviour
{
    [SerializeField] private FlightExamManager examManager;

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        examManager.TakeOff();
    }
}