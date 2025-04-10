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
    private bool willChangeChord = false;
    private float beatTimer = 0;

    private void Awake()
    {
        carPreviousInput = car.getHInput();
        carCurrentInput = car.getHInput();
    }
    private void Update()
    {
        //keep track of the time that has passed gets reset at the end of update if it is more than 1.
        beatTimer += Time.deltaTime;

        //updates the inputs to check if the player has just turned.
        carPreviousInput = carCurrentInput;
        carCurrentInput = car.getHInput();
        if (carPreviousInput == 0 && carCurrentInput != 0)
        {
            willChangeChord = true;
        }

        //chord changed is delayed to be on the beat instead of immediately
        if (willChangeChord && beatTimer >= 1)
        {
            willChangeChord = false;
            nextChordIndex = currentChordIndex;
            while (nextChordIndex == currentChordIndex)
            {
                nextChordIndex = Random.Range(0, chords.Length);
                //nextChordIndex++;
                if (nextChordIndex >= chords.Length)
                {
                    nextChordIndex = 0;
                }
            }
            chords[currentChordIndex].SetActive(false);
            currentChordIndex = nextChordIndex;
            chords[currentChordIndex].SetActive(true);
        }
           
        //beat timer is reset to 0
        if (beatTimer > 1 )
        {
            beatTimer = 0;
        }

    }
}
