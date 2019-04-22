using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTrackableEventHandlerExtended : DefaultTrackableEventHandler
{
    public GameObject audioPlayer;
    private PlayOnStateChange player;

    override protected void Start()
    {
        base.Start();
        player = audioPlayer.GetComponent<PlayOnStateChange>();
    }

    //Extending the functionality when the target is found
    override protected void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (player != null)
        {
            player.Initialize();
            player.PlayOnAppear();
        }
    }

    //Extending the functionality when the target dissapears
    override protected void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (player != null)
        {
            player.PlayOnDisappear();
        }
    }
}
