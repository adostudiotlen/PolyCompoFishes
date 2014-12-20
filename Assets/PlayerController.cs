using UnityEngine;
using System.Collections;

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


	void Awake()
	{
		tail = transform.FindChild ("Tail").gameObject;
		mouth = (transform.FindChild("Head")).FindChild ("Mouth").gameObject;
		engineParticleSystem = ((transform.FindChild ("Tail")).FindChild ("Silnik")).FindChild ("Particle System").gameObject;
		anim = (transform.FindChild("Head")).FindChild ("Head").GetComponent<Animator> ();
        //powerUps[(int) 0] = (transform.FindChild("PowerUps")).FindChild("PowerUp1").gameObject;
        //powerUps[(int) 1] = (transform.FindChild("PowerUps")).FindChild("PowerUp2").gameObject;
        //powerUps[(int) 2] = (transform.FindChild("PowerUps")).FindChild("PowerUp3").gameObject;
        for (int i = 0; i == powerUps.Length; i++)
        {
            powerUps[i].gameObject.SetActive(false);
        }
        healthPoints = 4;
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
		if(Input.GetKey (KeyCode.W))
		{
			this.rigidbody2D.AddForce(-this.transform.right * 0.1f * this.transform.localScale.x* this.transform.localScale.x, ForceMode2D.Impulse );
			engineParticleSystem.particleSystem.Emit(1);
		}

		if (Input.GetKey (KeyCode.Space)) 
		{
			PlayEatingAnim();
		}

		if (Input.GetKey (KeyCode.Escape)) 
		{
			Application.LoadLevel("menu");
		}

		angle = Input.GetAxis ("Horizontal");
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
        if (experience >= 50 && experience < 100)
        {
            powerUps[0].gameObject.SetActive(true);
            Debug.Log("Level 1");
        }
        else if (experience >= 100 && experience < 150)
        {
            powerUps[1].gameObject.SetActive(true);
            Debug.Log("Level 2");
        }
        else if (experience >= 150)
        {
            powerUps[2].gameObject.SetActive(true);
            Debug.Log("Level 3");
        }
        else
        {
            //nothing
        }
    }

    private void checkHealth()
    {
        if (healthPoints <= 0)
        {
            Time.timeScale = 0.0f;

        }
    }


    
}
