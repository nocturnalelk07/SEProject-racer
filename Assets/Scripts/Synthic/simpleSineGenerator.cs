using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleSineGenerator : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float amplitude = 0.5f;
    [SerializeField] private float frequency = 261.62f; //middle c

    private double phase;
    private double sampleRate;

    private void Awake()
    {
        sampleRate = AudioSettings.outputSampleRate;
    }

    private void OnAudioFilterRead(float[] data, int channels)
    {
        double phaseIncrement = frequency / sampleRate;

        for (int sample = 0; sample < data.Length; sample += channels)
        {
            float value = Mathf.Sin((float)phase * 2 * Mathf.PI) * amplitude;

            phase = (phase + phaseIncrement) % 1;

            for (int channel = 0; channel < channels; channel++)
            {
                data[sample + channel] = value;
            }
        }
    }
}
