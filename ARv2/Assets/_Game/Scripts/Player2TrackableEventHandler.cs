using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2TrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        playerScanCanvas.SetActive(false);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        playerScanCanvas.SetActive(true);
    }

}
