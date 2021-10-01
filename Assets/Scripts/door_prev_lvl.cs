using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_prev_lvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        int sceneInx = SceneManager.GetActiveScene().buildIndex;
        if (other.tag == "Player" && sceneInx > 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
