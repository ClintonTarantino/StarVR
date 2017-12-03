using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float minX, minY, maxX, maxY;

	Rigidbody playerRigidbody;

	void Awake()
	{
		playerRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		playerRigidbody.position = new Vector3
			(
				Mathf.Clamp(playerRigidbody.position.x, minX, maxX),
				Mathf.Clamp(playerRigidbody.position.y, minY, maxY),
				2.0f
			);

		playerRigidbody.rotation = Quaternion.identity;

	}
}
