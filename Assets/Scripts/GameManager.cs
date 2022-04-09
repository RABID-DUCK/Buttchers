using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject BallPrefab;
    public GameObject winPanel;
    int i;
    public bool gameOver = false;
    List<Ball> balls = new List<Ball>();
    void Start()
    {
        i = 0;
        Time.timeScale = 1;
        InvokeRepeating("SpawnNewBall", 3f, 3.2f);
    }

    // Update is called once per frame
    void Update()
    {
        DestroyBall();
        if (i==10)
        {
            gameOver = true;
            win();
        }
    }

    void SpawnNewBall()
    {
        if (balls.Count<6 && !gameOver)
        {
            var pos = new Vector3(Random.Range(-26f, 26f), 0f, 19f);
            var ball = Instantiate(BallPrefab, pos, Quaternion.identity);
            balls.Add(ball.GetComponent<Ball>());
        }
    }
    public int GetScore()
    {
        return i;
    }
    public void DestroyBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject == gameObject || hit.collider.gameObject.tag == "ball")
                {
                    Destroy(hit.collider.gameObject);
                    balls.Remove(hit.collider.gameObject.GetComponent<Ball>());
                    i++;
                }
            }
        }
    }

    public void win()
    {
           Time.timeScale = 0;
           winPanel.SetActive(true);
    
    }
}
