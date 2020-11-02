using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public bool startSound = false;

	public Spawner sp;
	public AudioManager am;

	public float jumpForce = 10f;
	public float waitTime = 2f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;
	public Transform playerPos;
	public Transform cameraPos;
	public Text ScreenText;

	public string currentColor;
	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;

	void Start ()
	{
		rb.isKinematic = true;
		SetRandomColor();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			am.Play("jump");
			ScreenText.enabled = false;
			rb.isKinematic = false;
			rb.velocity = Vector2.up * jumpForce;
		}
		if (playerPos.position.y + 6 < cameraPos.position.y)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "ColorChanger")
		{
			am.Play("colorswitch");
			Score.score += 100;
			sp.ColorChangerSpawner();
			sp.CircleSpawner();
			SetRandomColor();
			return;
		}

		if (col.tag != currentColor)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Magenta";
				sr.color = colorMagenta;
				break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
				break;
		}
	}
}
