using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private static GameObject canvas;
    private GameObject scoreCanvas;
    private GameObject plusCanvas;
    private GameObject effectscanvas;
    private bool canMove = true;
    public float moveSpeed = 300;
    public GameObject character;
    private Rigidbody2D characterBody;
    private float ScreenWidth;
    public GameObject slowdown;
    public GameObject slowdown2;
    private Vector2 currentpos;
    public GameObject scoreplus;
    private Sprite charSprite;
    public GameObject clouds;
   
   
   
   





    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        effectscanvas = GameObject.Find("EffectsCanvas");
        scoreCanvas = GameObject.Find("InGameScoreCanvas");
        plusCanvas = GameObject.Find("PlusScoreCanvas");
        canvas.SetActive(false);
        effectscanvas.SetActive(false);
        scoreCanvas.SetActive(true);
        ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody2D>();
        characterBody.velocity = new Vector2(0, -3.0f);
        plusCanvas.SetActive(false);
        
        charSprite = Resources.Load<Sprite>(PlayerPrefs.GetString("EquippedCharacter", "skydiver"));
        Debug.Log(charSprite);
        Debug.Log(PlayerPrefs.GetString("EquippedCharacter", "skydiver"));
        gameObject.GetComponent<SpriteRenderer>().sprite = charSprite;
        



    }


    ///////////////////// MOVEMENT ////////////////////////
    void Update()
    {
# if (UNITY_ANDROID || UNITY_IOS)
        if (canMove)
        {
            int i = 0;
            //loop over every touch found
            while (i < Input.touchCount)
            {
                if (Input.GetTouch(i).position.x > ScreenWidth / 2)
                {
                    characterBody.AddForce(new Vector2(6.0f, 0));
                }
                if (Input.GetTouch(i).position.x < ScreenWidth / 2)
                {
                    //move left
                    characterBody.AddForce(new Vector2(-6.0f, 0));
                }
                ++i;
            }
        }
#endif
    }

    private void FixedUpdate()
    {
        characterBody.velocity += new Vector2(0, -0.003f);
#if (UNITY_EDITOR || UNITY_WEBGL || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN)
        characterBody.velocity += new Vector2(Input.GetAxis("Horizontal")/5, 0);
#endif
    }



    /////////////////////////////////////////////////////////////////////////////






    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            transform.DetachChildren();
            Destroy(gameObject);
            canvas.SetActive(true);
            canMove = false;
            scoreCanvas.SetActive(false);
            effectscanvas.SetActive(false);
            Time.timeScale = 1f;
            clouds.SetActive(false);

        }


    }

}