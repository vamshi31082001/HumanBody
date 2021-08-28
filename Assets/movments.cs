using UnityEngine;

public class movments : MonoBehaviour
{
	public  Transform player;

	public float speed;
	public float RotateSpeed = 30f;

	void Update()
	{
		Debug.Log (Time.deltaTime);
		if (Input.GetKey(KeyCode.W)) 
		{
			player.position = new Vector3 (player.position.x + speed*Time.deltaTime, player.position.y, player.position.z);
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			player.position = new Vector3 (player.position.x - speed*Time.deltaTime, player.position.y, player.position.z);
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			player.position = new Vector3 (player.position.x,player.position.y,player.position.z + speed*Time.deltaTime);

		}
		if (Input.GetKey(KeyCode.A)) 
		{
			player.position = new Vector3 (player.position.x,player.position.y,player.position.z - speed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.Space)) 
		{
			player.position = new Vector3 (player.position.x,player.position.y + speed*Time.deltaTime,player.position.z);
		}
		if (Input.GetKey (KeyCode.C)) 
		{
			player.position = new Vector3 (player.position.x,player.position.y - speed*Time.deltaTime,player.position.z);
		}
		if (Input.GetKey(KeyCode.P))
		{
			player.localScale = new Vector3(player.localScale.x + 1, player.localScale.y, player.localScale.z);
		}
		if (Input.GetKey(KeyCode.O))
		{
			player.localScale = new Vector3(player.localScale.x , player.localScale.y + 1, player.localScale.z);
		}
		
		if (Input.GetKey(KeyCode.RightArrow))
		{
			player.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			player.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
		}
	}
}