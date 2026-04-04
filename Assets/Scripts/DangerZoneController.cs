// DangerZoneController.cs
// CENG 454 - HW2 Midterm
// Author : Beyza Nur Elitok | Student ID: 210444043

using UnityEngine;
using System.Collections;

public class DangerZoneController : MonoBehaviour
{
    [SerializeField] private FlightExamManager examManager;
    [SerializeField] private MissileLauncher missileLauncher;
    [SerializeField] private float missileDelay = 5f;

    private Coroutine activeCountdown;
    private Transform playerTransform;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        playerTransform = other.transform;
        examManager.EnterDangerZone();
        activeCountdown = StartCoroutine(MissileCountdown());
        
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Trigger hit by: " + other.name + " | Tag: " + other.tag);

        if (!other.CompareTag("Player")) return;
        
            if (activeCountdown != null)
            {
                StopCoroutine(activeCountdown);
                activeCountdown = null;
            }
            missileLauncher.DestroyActiveMissile();
            examManager.ExitDangerZone();

    }

    private IEnumerator MissileCountdown()
    {
        yield return new WaitForSeconds(missileDelay);
        missileLauncher.Launch(playerTransform);
    }
}