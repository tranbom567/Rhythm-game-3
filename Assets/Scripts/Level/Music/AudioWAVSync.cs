using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWAVSync : MonoBehaviour
{
    private static int sampleWindow = 64;
    public static float loudness(int startPos,AudioClip clip)
    {
        if ((startPos-sampleWindow) < 0) return 0;
        float[] wavData = new float[sampleWindow];
        clip.GetData(wavData, startPos-sampleWindow);
        float totalLoudness=0;
        foreach (float dat in wavData)
            totalLoudness += Mathf.Abs(dat);
        return totalLoudness / sampleWindow;
    }
}
