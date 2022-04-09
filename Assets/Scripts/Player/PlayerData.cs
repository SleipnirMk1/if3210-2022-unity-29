using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Versi nyoba sendiri bikin player data
    // Variables //
    public static PlayerData instance;      // Singleton

    [SerializeField]
    private string playerName = "Joko";      // Buat nama player, mungkin namanya mo bisa ganti"

    public List<ZenScore> zenScoreBoard = new List<ZenScore>();
    public List<WaveScore> waveScoreBoard = new List<WaveScore>();

    [SerializeField]
    private int listMaxElement = 3;

    // Functions //
    private void Awake()                    // Biar duluan klo ada proses lain yg pake void start
    {
        if (instance == null)               // Klo blom ada datanya
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Ditaro disini biar (mungkin) ga infinite loop
            Debug.Log("This is instance");
        }
        else                                // Klo udh ada datanya
        {
            Destroy(gameObject);
            Debug.Log("Destroyed instance");
        }

        // ZenScore testZen = new ZenScore(); DEBUGG
        // testZen.name = "fulan";
        // testZen.time = 20;
        // zenScoreBoard.Add(testZen);

        // WaveScore waveTest = new WaveScore();
        // waveTest.name = "fulan2";
        // waveTest.score = 20;
        // waveTest.maxWaves = 5;
        // waveScoreBoard.Add(waveTest);
    }

    public void setPlayerName(string name)
    {
        playerName = name;
    }

    public void addZenScoreBoard(ZenScore newData)
    {
        int i = 0;
        foreach (var elmt in zenScoreBoard) {
            if (elmt.time < newData.time) {
                zenScoreBoard.Insert(i, elmt);
                if (zenScoreBoard.Count > listMaxElement) {
                    zenScoreBoard.RemoveAt(zenScoreBoard.Count - 1);
                }
                break;
            }
            i += 1;
        }
    }

    public void addWaveScoreBoard(WaveScore newData)
    {
        int i = 0;
        foreach (var elmt in waveScoreBoard) {
            if (elmt.score < newData.score) {
                waveScoreBoard.Insert(i, elmt);
                if (waveScoreBoard.Count > listMaxElement) {
                    waveScoreBoard.RemoveAt(waveScoreBoard.Count - 1);
                }
                break;
            }
            i += 1;
        }
    }

    public List<ZenScore> getZenScoreBoard()
    {
        return zenScoreBoard;
    }

    public List<WaveScore> getWaveScoreBoard()
    {
        return waveScoreBoard;
    }
}