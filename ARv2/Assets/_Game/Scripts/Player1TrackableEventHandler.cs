using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1TrackableEventHandler : DefaultTrackableEventHandler
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

    private void RotateToDamage()
    {
        //if ()
        //{

        //}
    }
}
