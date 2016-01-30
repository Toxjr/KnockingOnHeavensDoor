﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text timeText;
	public Text lifeText;

	public int monsterToWin = 100;
	private int monstersInGoal = 0;

	public float levelTimeLimitSeconds = 60;
	private float levelTimePassed = 0;

	public void MonsterFinished(){
		monstersInGoal++;
		if (monstersInGoal >= monstersInGoal) {
			SceneManager.LoadScene ("winScreen");
		}
	}

	// Use this for initialization
	void Start () {
		//text = textField.GetComponents<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		levelTimePassed += Time.deltaTime;
		timeText.text = "Time Left: " + Mathf.Round(levelTimeLimitSeconds - levelTimePassed) + "s";
		lifeText.text = "Heaven Gate: " + Mathf.Round(monsterToWin - monstersInGoal);
		if (levelTimePassed >= levelTimeLimitSeconds) {
			SceneManager.LoadScene ("loseScreen");
		}
	}
}
