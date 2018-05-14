using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautTrackableEventHandler : DefaultTrackableEventHandler
{
    [SerializeField]
    private GameObject imageTarget;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }

    private void RotateToDamage()
    {
        if ()
        {

        }
    }
}
