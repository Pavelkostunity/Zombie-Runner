using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameoverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        gameoverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gameoverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
