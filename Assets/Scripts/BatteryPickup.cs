using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float lightangle = 71f;
    [SerializeField] float lightintensity = 2f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(lightangle);
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightIntencity(lightintensity);
            Destroy(gameObject);
        }
    }
}
