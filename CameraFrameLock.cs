using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFrameLock : MonoBehaviour
{
    // It loosely sets the framerate
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }
}
