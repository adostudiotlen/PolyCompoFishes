using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	float angle;
	GameObject tail;
	GameObject mouth;
	public int experience = 0;
	GameObject engineParticleSystem;
    public GameObject[] powerUps;
    public int healthPoints;
	Animator anim;
	//GameObject skeleton;

	public GameObject gameOver;
	public GameObject tutorial;
	GameObject maska;
	public GameObject fader;
	bool isDead = false;

	GameObject[] injuries = new GameObject[3];


	void Awake()
	{
		tail = transform.FindChild ("Tail").gameObject;
		mouth = (transform.FindChild("Head")).FindChild ("Mouth").gameObject;
		engineParticleSystem = ((transform.FindChild ("Tail")).FindChild ("Silnik")).FindChild ("Particle System").gameObject;
		anim = (transform.FindChild("Head")).FindChild ("Head").GetComponent<Animator> ();
//		skeleton = (transform.FindChild ("Head")).FindChild ("Skeleton").gameObject;
        //powerUps[(int) 0] = (transform.FindChild("PowerUps")).FindChild("PowerUp1").gameObject;
        //powerUps[(int) 1] = (transform.FindChild("PowerUps")).FindChild("PowerUp2").gameObject;
        //powerUps[(int) 2] = (transform.FindChild("PowerUps")).FindChild("PowerUp3").gameObject;
		injuries [0] = ((transform.FindChild ("Head")).FindChild ("Head")).FindChild ("krew1").gameObject;
		injuries [1] = ((transform.FindChild ("Head")).FindChild ("Head")).FindChild ("krew2").gameObject;
		injuries [2] = ((transform.FindChild ("Head")).FindChild ("Head")).FindChild ("krew3").gameObject;
		maska = transform.FindChild ("Head").FindChild ("Head").FindChild ("Maska").gameObject;
        for (int i = 0; i == powerUps.Length; i++)
        {
            powerUps[i].gameObject.SetActive(false);
        }
        healthPoints = 4;

		//fader = GameObject.FindGameObjectWithTag ("fader");

	}

    void Update()
	{
		this.transform.localScale = new Vector3(1.0f + (float)experience * 0.1f,1.0f + (float)experience * 0.1f, 1.0f);
		this.rigidbody2D.mass = 1.0f * this.transform.localScale.x;
		CheckExp();
        checkHealth();
	}

	void FixedUpdate()
	{
		if (!isDead) 
		{
			if(Input.GetKey (KeyCode.W))
			{
				this.rigidbody2D.AddForce(-this.transform.right * 0.1f * this.transform.localScale.x* this.transform.localScale.x, ForceMode2D.Impulse );
				engineParticleSystem.particleSystem.Emit(1);
			}
			
			if (Input.GetKey (KeyCode.Space)) 
			{
				PlayEatingAnim();
			}
			angle = Input.GetAxis ("Horizontal");

			if (Input.GetKey (KeyCode.Escape)) 
			{
				Application.LoadLevel("menu");
			}
		}






		//Debug.Log (angle);
		//this.rigidbody2D.MoveRotation (angle * 45.0f);
		//transform.Rotate (-this.transform.forward, angle * 45.0f * 0.05f);
		rigidbody2D.angularVelocity = angle * -45.0f * 3.0f;
		tail.transform.localRotation = Quaternion.AngleAxis (90 + angle * 45.0f, this.transform.forward);

		if (Input.GetKey (KeyCode.Space)) 
		{

		}

	}

	public void AddExperience(int amount)
	{
		experience += amount;
	}

	public int GetExperience()
	{
		return experience;
	}

	public void PlayEatingAnim()
	{
		anim.Play ("eating");
	}

    private void CheckExp()
    {
		if (experience >= 10 && experience < 50)
		{
			//powerUps[3].gameObject.SetActive(true);
			maska.SetActive(true);
			string text10exp = "Level up! You can eat asteroids!";
			if(tutorial.GetComponent<Text>().text != text10exp)
			{
				tutorial.GetComponent<Text>().text = text10exp;
				tutorial.GetComponent<tutController>().RestartText();
			}

		}
        if (experience >= 50 && experience < 100)
        {
            powerUps[0].gameObject.SetActive(true);
            //Debug.Log("Level 1");
        }
        else if (experience >= 100 && experience < 150)
        {
            powerUps[1].gameObject.SetActive(true);
            Debug.Log("Level 2");
			string text100exp = "Level up! You can eat planets!";
			if(tutorial.GetComponent<Text>().text != text100exp)
			{
				tutorial.GetComponent<Text>().text = text100exp;
				tutorial.GetComponent<tutController>().RestartText();
			}
        }
        else if (experience >= 150)
        {
            powerUps[2].gameObject.SetActive(true);
            Debug.Log("Level 3");
        }
		else if (experience >= 500)
        {
			string text500exp = "Level up! You can eat everything!";
			if(tutorial.GetComponent<Text>().text != text500exp)
			{
				tutorial.GetComponent<Text>().text = text500exp;
				tutorial.GetComponent<tutController>().RestartText();
			}
            //nothing
        }


		if(experience >=3000)
		{
			fader.SetActive(true);
		}
    }

    private void checkHealth()
    {
		if (healthPoints == 3) 
		{
			injuries[0].SetActive(true);
		}
		if (healthPoints == 2) 
		{
			injuries[1].SetActive(true);
		}
		if (healthPoints == 1) 
		{
			injuries[2].SetActive(true);
		}
		
        if (healthPoints <= 0)
        {
            //Time.timeScale = 0.0f;
			isDead = true;
			//Instantiate(skeleton);
			gameOver.SetActive(true);
			//this.enabled = false;

			fader.SetActive(true);
			//Application.LoadLevel("end");

        }
    }

	public void EndPlaying()
	{
		Application.LoadLevel ("end");
	}
    
}
