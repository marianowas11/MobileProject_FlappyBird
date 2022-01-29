using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    [SerializeField]
    private AudioSource _audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        _audioSource.Play();
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
