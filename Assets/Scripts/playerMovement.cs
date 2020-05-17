using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float shipSpeed;
	float shipBoundaryRadius = 0.5f;
	Rigidbody2D rbShip;
	
	void Start()
    {// calls on the ridgidbody2d to move.
		rbShip = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
	
		Vector3 pos = transform.position;


		// calculate the orthographic width based on the screen ratio
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		// Now do horizontal bounds
		if (pos.x + shipBoundaryRadius > widthOrtho)
		{
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if (pos.x - shipBoundaryRadius < -widthOrtho)
		{
			pos.x = -widthOrtho + shipBoundaryRadius;
		}

		// Finally, update our position!!
		transform.position = pos;

	}

	 void FixedUpdate()
	{// allows players to move left and right
		float shipMove = Input.GetAxis("Horizontal");
		rbShip.velocity = new Vector2 (shipSpeed * shipMove , rbShip.velocity.y);
	}
}
