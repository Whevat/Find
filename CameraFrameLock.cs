using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFrameLock : MonoBehaviour
{
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 45;
    }
}
