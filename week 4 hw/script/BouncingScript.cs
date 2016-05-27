using UnityEngine;
using System.Collections;

public class BouncingScript : MonoBehaviour
{
	public float bounceSpeed = 0.002f;

	public bool itemBounceUp = false;

	void Start ()
	{
		StartCoroutine ("itemBounce", 0.8f);
	}

	void Update ()
	{
		Vector3 myTransform = transform.position;

		if (itemBounceUp == true)
		{
			myTransform.y += bounceSpeed;
			transform.position = myTransform;
		}

		else if (itemBounceUp == false)
		{
			myTransform.y -= bounceSpeed;
			transform.position = myTransform;
		}
	}

	IEnumerator itemBounce (float repeatAfter)
	{
		int i;
		for (i=1; i>0; i++)
		{
			if (itemBounceUp)
			{
				itemBounceUp = false;
				yield return new WaitForSeconds (repeatAfter);
			}
			else if (itemBounceUp == false)
			{
				itemBounceUp = true;
				yield return new WaitForSeconds (repeatAfter);
			}
		}
	}
}