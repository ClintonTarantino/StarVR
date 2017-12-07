using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    GameController gamecontroller;

	Rigidbody enemyRigidBody;
	float speed = 5f;

	AudioSource source;

    void Awake()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        enemyRigidBody = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    void Start()
    {
        enemyRigidBody.angularVelocity = Random.insideUnitSphere * speed;
        enemyRigidBody.velocity = transform.forward * speed;
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            source.Play();

            //Set to game over
            gamecontroller.GameOver();
            Destroy(gameObject,0.5f);
            Destroy(other.gameObject);
        }
    }

}
