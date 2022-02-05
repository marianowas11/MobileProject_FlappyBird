using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject pauseCanvas;
    public GameObject pointsCanvas;
    public AudioSource _audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
        _audioSource= GetComponent<AudioSource>();
    }

    public void GameOver()
    {
        _audioSource.Play();
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        pointsCanvas.SetActive(false);
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void Pause()//Pauses the game after button click
    {
        Time.timeScale = 0;

        Fly._audioSource.volume = 0f;
        pauseCanvas.SetActive(true);
        pointsCanvas.SetActive(false);
    }

    public void Resume()//Resumes the game after button click in pause Canvas
    {
        pauseCanvas.SetActive(false);
        pointsCanvas.SetActive(true);
        Fly._audioSource.volume = 0.5f;
        Time.timeScale = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
