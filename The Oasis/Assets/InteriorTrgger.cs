using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteriorTrgger : MonoBehaviour
{
    public GameObject player;

    public enum scenes
    {
        Village,
        Home
    }

    public scenes loadScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            SceneManager.LoadScene((int)loadScene);
        }
    }
}
