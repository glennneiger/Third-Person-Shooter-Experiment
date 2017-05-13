﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseAndLockCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        //if (Input.GetKeyDown(KeyCode.Escape)) {
        //if (Input.GetButtonDown("Escape") || GameObject.Find("EscapeMenuImage").activeInHierarchy == true) {
        if (Input.GetButtonDown("Escape") || GameObject.Find("WinScreenImage").activeInHierarchy == true) {
            print("Inside 'if (Input.GetButtonDown(Escape)) {...}' ...");
            PauseGame();
        }

        if (Cursor.lockState == CursorLockMode.None && Input.GetButtonDown("Fire1") && GameObject.Find("EscapeMenuImage").activeInHierarchy == false) {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void PauseGame() {
        print("Inside PauseGame() ...");
        //Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        Time.timeScale = 0;

        if (Cursor.lockState == CursorLockMode.Locked) {
            print("Inside 'if (Cursor.lockState == CursorLockMode.Locked)' ...");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        /*else if (Cursor.lockState == CursorLockMode.None) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }*/

    }

    public void UnpauseGame() {
        print("Inside PauseGame() ...");
        //Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        Time.timeScale = 1;

        if (Cursor.lockState == CursorLockMode.None) {
            print("Inside 'if (Cursor.lockState == CursorLockMode.None)' ...");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        /*else if (Cursor.lockState == CursorLockMode.None) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }*/

    }

    public void Quit() {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}