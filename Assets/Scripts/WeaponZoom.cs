using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera FPSCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedoutSensitivity = 2f;
    [SerializeField] float zoomedinSensitivity = .5f;

    bool zoomedInTooggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInTooggle == false)
            {
                zoomedInTooggle = true;
                FPSCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomedinSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedinSensitivity;
            }
            else
            {
                zoomedInTooggle = false;
                FPSCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomedoutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedoutSensitivity;
            }
        }
    }
    private void OnDisable()
    {
        zoomedInTooggle = false;
        FPSCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedoutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedoutSensitivity;
    }
}
