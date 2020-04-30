﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
	public GameObject pauseButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P) && !pauseButton.activeInHierarchy) {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 0.0f;
			pauseButton.SetActive (true);
		} else if (Input.GetKeyDown (KeyCode.P) && pauseButton.activeInHierarchy) {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            pauseButton.SetActive (false);
			Time.timeScale = 1.0f;
		}
	}
}
