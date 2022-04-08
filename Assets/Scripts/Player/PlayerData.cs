using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Versi nyoba sendiri bikin player data
    // Variables //
    public static PlayerData instance;      // Singleton

    public string playerName = "Joko";      // Buat nama player, mungkin namanya mo bisa ganti"
    public int score;

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
    }

}