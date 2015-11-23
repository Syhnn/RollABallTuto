using UnityEngine;
using System.Collections;

public class CoinRotator : MonoBehaviour
{
    public float rotationSpeed;
    public float verticalSpeed;
    public float verticalShift;

    private Vector3 originalPosition;
    private Vector3 verticalMovement;

	void Awake ()
	{
        originalPosition = transform.position;
        verticalMovement = new Vector3(0, verticalSpeed * 1, 0);
	}

	void Update ()
	{
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);

        // If the coin is too low or too high, change the direction of the movement
        /*if (transform.position.y < originalPosition.y - verticalShift || transform.position.y > originalPosition.y + verticalShift)
            verticalMovement.y *= -1;

        transform.Translate(verticalMovement * Time.deltaTime);*/
    }

}
