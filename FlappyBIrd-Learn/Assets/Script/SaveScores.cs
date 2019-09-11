using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScores : MonoBehaviour
{
    [SerializeField] private Text ScoresText;

    void Update()
    {
        //menampilkan highscore
        ScoresText.text = PlayerPrefs.GetInt("HighestScore").ToString();
    }
}
