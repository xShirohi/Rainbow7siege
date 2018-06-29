using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private string name;
    private int currentScore;
    private int victoryPoints;
    private bool currentRoundWinner;
    private int currentBet;
    private int moveLocations;


	// Use this for initialization
	void Start (string name) {
        this.name = name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Returns the player's current score
    public int getCurrentScore()
    {
        return currentScore;
    }

    //Returns the player's name
    public string getName()
    {
        return name;
    }

    //Returns the player's victory points
    public int getVictoryPoints()
    {
        return victoryPoints;
    }
}
