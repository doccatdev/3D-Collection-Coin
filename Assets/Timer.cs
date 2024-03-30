using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    bool gameFinished = false;

    public GameObject gameOverCanvas; // Assign your game over canvas GameObject in the Inspector

    void Update()
    {
        if (!gameFinished)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                remainingTime = 0;
                GameOver();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        timerText.text = "00:00";
        Debug.Log("Game Selesai");
        // Activate the game over canvas
        gameOverCanvas.SetActive(true);
        // Tambahkan logika tambahan yang perlu dilakukan ketika permainan berakhir di sini
        // Contoh: Menampilkan layar permainan selesai, menghentikan pergerakan pemain, dll.
        gameFinished = true;
    }
}
