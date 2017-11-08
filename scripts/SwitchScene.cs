﻿//FILE:     SwitchScene.cs
//AUTHOR:   Hao Xu (haoxunico@gmail.com)
//DATE:     11/1/2017
//PURPOSE: Switch the scenes when done recording in one scene 
//INFO: Adjust the order of scenes in this script, look in the build settings for the scene number.
//  The ending scene should start with the line UnityEditor.EditorApplication.isPlaying = false;
//      to terminate the program, otherwise it will never terminate!


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

    public bool finished = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (finished)
        {
            if (SceneManager.GetActiveScene().name.Equals("town"))
            {
                UnityEditor.EditorApplication.isPlaying = false;
                SceneManager.LoadScene(2, LoadSceneMode.Single);
                Object.Destroy(GameObject.Find("VideoCaptureCtrl"));
                finished = false;
            }
            else if (SceneManager.GetActiveScene().name.Equals("High Resolution Terrain Scene"))
            {
                SceneManager.LoadScene(3, LoadSceneMode.Single);
                Object.Destroy(GameObject.Find("VideoCaptureCtrl"));
                finished = false;
            }
            else if (SceneManager.GetActiveScene().name.Equals("Castle wireframe"))
            {
                SceneManager.LoadScene(4, LoadSceneMode.Single);
                Object.Destroy(GameObject.Find("VideoCaptureCtrl"));
                finished = false;
                //UnityEditor.EditorApplication.isPlaying = false;
            }
            else if (SceneManager.GetActiveScene().name.Equals("scifi"))
            {
                SceneManager.LoadScene(5, LoadSceneMode.Single);
                Object.Destroy(GameObject.Find("VideoCaptureCtrl"));
                finished = false;
            }
            else
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
	}
}
