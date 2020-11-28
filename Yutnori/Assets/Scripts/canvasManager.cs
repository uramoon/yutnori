﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    public Text[] pInfo = new Text[4];
    public Button startBtn;
    public Text text;

    private void Awake()
    {
        pInfo[1] = GameObject.Find("P2nickName").GetComponent<Text>();
        pInfo[0] = GameObject.Find("P1nickName").GetComponent<Text>();

        if (SceneManager.GetActiveScene().name.Equals("GAME1"))
            text.GetComponent<Text>().text = "윷던지기";
        else
            text.GetComponent<Text>().text = "GameStart";
    }

    // Update is called once per frame
    void Update()
    {
        setPlayerInfo();
    }
    public void setPlayerInfo()
    {
        for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
        {
            pInfo[i].text = PhotonNetwork.PlayerList[i].NickName;
        }

    }
}