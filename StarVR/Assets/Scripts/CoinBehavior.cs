using UnityEngine;

public class CoinBehavior : MonoBehaviour {

    public int points;
    
    GameController gamecontroller;

    Rigidbody enemyRigidBody;
    float speed = 5f;

    AudioSource source;

    void Awake()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
        enemyRigidBody = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    void Start()
    {
        enemyRigidBody.velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            source.Play();

            //Set to game over
            // gamecontroller.AddScore(points);
            Destroy(gameObject, 0.5f);
            Destroy(other.gameObject);
        }
    }
}

