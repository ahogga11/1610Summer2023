using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ballPrefab;

    public int ball;

    // Start is called before the first frame update

    public float timeRemaining = 2f;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining < 0)
        {
            timeRemaining = Random.Range(1, 3);
            spawn_ball();
        }
        void spawn_ball()
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            Instantiate(ballPrefab, randomPosition, Quaternion.identity);
        }



        void OnTriggerEnter(Collider Col)
        {
            if (Col.gameObject.tag == "Ball")
            {
                Debug.Log("Ball Collected!");
                ball = ball + 1;
                Col.gameObject.SetActive(false);
                Destroy(Col);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                Instantiate(ballPrefab, randomPosition, Quaternion.identity);
            }
        }
        // Update is called once per frame
    }
}
