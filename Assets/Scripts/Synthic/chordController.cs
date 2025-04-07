using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chordController : MonoBehaviour
{
    //this script will enable and disable selected chords based on 
    [SerializeField] private GameObject[] chords;
    [SerializeField] private CarControl car;
    private int currentChordIndex = 0;
    private int nextChordIndex = 0;
    private float carPreviousInput;
    private float carCurrentInput;

    private void Awake()
    {
        carPreviousInput = car.getHInput();
        carCurrentInput = car.getHInput();
    }
    private void Update()
    {
        carPreviousInput = carCurrentInput;
        carCurrentInput = car.getHInput();
        if (carPreviousInput == 0 && carCurrentInput != 0)
        {
            nextChordIndex = currentChordIndex;
            while (nextChordIndex == currentChordIndex)
            {
                //nextChordIndex = Random.Range(0, chords.Length);
                nextChordIndex++;
                if (nextChordIndex >= chords.Length)
                {
                    nextChordIndex = 0;
                }
            }
            chords[currentChordIndex].SetActive(false);
            currentChordIndex = nextChordIndex;
            chords[currentChordIndex].SetActive(true);
            
        }
        
    }
}
