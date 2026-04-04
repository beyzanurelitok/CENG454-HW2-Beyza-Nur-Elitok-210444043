// AircraftThreatHandler.cs
// CENG 454 - HW2 Midterm: Sky-High Prototype II
// Author : Beyza Nur Elitok | Student ID: 210444043

using UnityEngine;

public class AircraftThreatHandler : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private FlightExamManager examManager;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            Destroy(other.gameObject);
            ResetAircraft();
            examManager.OnMissileHit();
        }
    }

    private void ResetAircraft()
    {
        if (respawnPoint != null)
        {
            transform.position = respawnPoint.position;
            transform.rotation = respawnPoint.rotation;
        }

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}