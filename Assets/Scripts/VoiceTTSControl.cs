using Meta.WitAi.TTS.Utilities;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VoiceTTSControl : MonoBehaviour
{
    [SerializeField] private TTSSpeaker speaker;
    [SerializeField] private DataSO data;
    [SerializeField] private TextMeshProUGUI TextContent;
    [SerializeField] private OVRHand RightHand;
    [SerializeField]
    [Range(0.0f, 10.0f)] private float timeGap = 6.0f;
    private float currentTime = 0.0f;

    private int currentIndex = 0;
    private bool canPlay = false;


    private bool isFirst = true;

    private void Start()
    {
        speaker.Events.OnTextPlaybackFinished.AddListener(NextText);
    }

    private void NextText(string data)
    {
        currentIndex++;
        canPlay = true;
    }

    private void Update()
    {
        /* for controller testing
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            canPlay = true;
        } */

        // handtracking pinch for 2 seoncds to start
        if (RightHand.GetFingerIsPinching(OVRHand.HandFinger.Index))
        {
            if(isFirst)
            {
                canPlay = true;
                isFirst = false;
            }
        }
        

        if(canPlay)
        {
            if (currentIndex < data.Scenarios.Count)
            {
                TextContent.text = data.Scenarios[currentIndex];
                speaker.SpeakQueued(data.Scenarios[currentIndex]);
                // Debug.Log("Button Detection");
            }
            canPlay = false;
        }

        if(currentIndex == 3)
        {
            canPlay = false;
        }
    }
        
}
