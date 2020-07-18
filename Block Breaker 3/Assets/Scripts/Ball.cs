
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    Vector2 ballToPaddleDist;
    bool hasStarted = false;
    [SerializeField] float velX = 2f;
    [SerializeField] float vely = 15f;
    [SerializeField] AudioClip[] audios;
    Rigidbody2D rb;
    [SerializeField] float randomness = 0.5f;
 
    void Start()
    {
        ballToPaddleDist = transform.position - paddle1.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            StickBallToPaddle();
            LaunchBallOnMouseClick();
        }

      
    }

    private void LaunchBallOnMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(velX, vely);
        }
    }

    private void StickBallToPaddle()
    {
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + ballToPaddleDist;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 vel = new Vector2(Random.Range(0, randomness), Random.Range(0, randomness));

        if(hasStarted)
        {
            AudioClip clip = audios[UnityEngine.Random.Range(0, audios.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
        
    }
}
