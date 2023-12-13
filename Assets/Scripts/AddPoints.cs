using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _audioSource= GetComponent<AudioSource>();
        _audioSource.Play();
        Points.points++;
    }
    // Start is called before the first frame update
    //smt
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
