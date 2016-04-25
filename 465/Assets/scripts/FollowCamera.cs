using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public GameObject target;
	public GameObject target2;
	public GameObject player;
	public float abovePlayerOffsetZ;
	public float abovePlayerOffsetY;
	private bool followCam = true;
	public float damping = 1;
	Vector3 offset;

	void Start()
	{
		target2 = GameObject.Find("Ball");
		target = GameObject.Find("Player(Clone)");
		player = GameObject.Find("Player(Clone)");
		offset = target.transform.position - transform.position;
		offset.z = 10;
	}

	void LateUpdate()
	{

		if (Input.GetButtonDown("FollowCam"))
		{
			followCam = !followCam;
		}


		if (followCam)
		{
			Vector3 direction = target2.transform.position - transform.position;
			direction = direction.normalized;
			transform.position = new Vector3(player.transform.position.x - 5 * direction.x, player.transform.position.y - 5 * direction.y + 3, player.transform.position.z - 9 * direction.z);
		}


		float currentAngle = transform.eulerAngles.y;
		float desiredAngle = target2.transform.eulerAngles.y;
		if(!followCam)
			desiredAngle = target.transform.eulerAngles.y;

		float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);
		if (followCam)
		{
			transform.LookAt(new Vector3(target2.transform.position.x, target2.transform.position.y, target2.transform.position.z));
		}
		if (!followCam)
		{
			Quaternion rotation = Quaternion.Euler(0, angle, 0);
			transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z) - (rotation * offset);
			transform.LookAt(new Vector3(target.transform.position.x, target.transform.position.y + 2, target.transform.position.z));
		}
	}
}
