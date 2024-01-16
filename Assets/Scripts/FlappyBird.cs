using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject gameOverObj;
    public float speed ;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up*speed);
        }
    }
    public void resetGame()
    {
        SceneManager.LoadScene(0);
    }
    void gameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver();
    }
}
