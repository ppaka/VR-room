using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockObject : MonoBehaviour
{
    public Transform clockHour, clockMinute, clockSecond;

    private void Update()
    {
        clockHour.localRotation = Quaternion.Euler(System.DateTime.Now.Hour / 12f * 360 + 90 + System.DateTime.Now.Minute / 60f * 360 / 12f, 0, -90);
        clockMinute.localRotation = Quaternion.Euler(System.DateTime.Now.Minute / 60f * 360 + 90 + System.DateTime.Now.Second / (60f * 60f) * 360, 0, -90);
        clockSecond.localRotation = Quaternion.Euler(System.DateTime.Now.Second / 60f * 360 + 90, 0, -90);
    }
}
