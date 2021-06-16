using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharShop : MonoBehaviour
{
    public Sprite owned;
    public Sprite equipped;
    public Sprite locked;

    private GameObject SkydiverButton;
    private GameObject SkydiverText;

    private GameObject AsteroidButton;
    private GameObject AsteroidText;

    private GameObject UfoButton;
    private GameObject UfoText;

    private GameObject ParachuterButton;
    private GameObject ParachuterText;

    private GameObject DivebirdButton;
    private GameObject DivebirdText;

    private GameObject HeroButton;
    private GameObject HeroText;


    // Start is called before the first frame update
    void Start()
    {
        SkydiverButton = GameObject.Find("SkydiverButton");
        SkydiverText = GameObject.Find("SkydiverText");
        if (PlayerPrefs.GetFloat("HighScore") >= 0)
        {
            SkydiverButton.GetComponent<Button>().interactable = true;
            SkydiverButton.GetComponent<Image>().sprite = owned;
            SkydiverText.SetActive(false);
            if (PlayerPrefs.GetString("EquippedCharacter", "skydiver") == "skydiver")
            {
                SkydiverButton.GetComponent<Image>().sprite = equipped;
            }
        }

        AsteroidButton = GameObject.Find("AsteroidButton");
        AsteroidText = GameObject.Find("AsteroidText");
        if (PlayerPrefs.GetFloat("HighScore") >= 10)
        {
            AsteroidButton.GetComponent<Button>().interactable = true;
            AsteroidButton.GetComponent<Image>().sprite = owned;
            AsteroidText.SetActive(false);
            if (PlayerPrefs.GetString("EquippedCharacter", "skydiver") == "asteroid")
            {
                AsteroidButton.GetComponent<Image>().sprite = equipped;
            }
        }

        UfoButton = GameObject.Find("UfoButton");
        UfoText = GameObject.Find("UfoText");
        if (PlayerPrefs.GetFloat("HighScore") >= 20)
        {
            UfoButton.GetComponent<Button>().interactable = true;
            UfoButton.GetComponent<Image>().sprite = owned;
            UfoText.SetActive(false);
            if (PlayerPrefs.GetString("EquippedCharacter", "skydiver") == "ufo")
            {
                UfoButton.GetComponent<Image>().sprite = equipped;
            }
        }

        ParachuterButton = GameObject.Find("ParachuterButton");
        ParachuterText = GameObject.Find("ParachuterText");
        if (PlayerPrefs.GetFloat("HighScore") >= 30)
        {
            ParachuterButton.GetComponent<Button>().interactable = true;
            ParachuterButton.GetComponent<Image>().sprite = owned;
            ParachuterText.SetActive(false);
            if (PlayerPrefs.GetString("EquippedCharacter", "skydiver") == "parachuter")
            {
                ParachuterButton.GetComponent<Image>().sprite = equipped;
            }
        }

        DivebirdButton = GameObject.Find("DivebirdButton");
        DivebirdText = GameObject.Find("DivebirdText");
        if (PlayerPrefs.GetFloat("HighScore") >= 40)
        {
            DivebirdButton.GetComponent<Button>().interactable = true;
            DivebirdButton.GetComponent<Image>().sprite = owned;
            DivebirdText.SetActive(false);
            if (PlayerPrefs.GetString("EquippedCharacter", "skydiver") == "divebird")
            {
                DivebirdButton.GetComponent<Image>().sprite = equipped;
            }
        }

        HeroButton = GameObject.Find("HeroButton");
        HeroText = GameObject.Find("HeroText");
        if (PlayerPrefs.GetFloat("HighScore") >= 50)
        {
            HeroButton.GetComponent<Button>().interactable = true;
            HeroButton.GetComponent<Image>().sprite = owned;
            HeroText.SetActive(false);
            if(PlayerPrefs.GetString("EquippedCharacter", "skydiver") == "hero")
            {
                HeroButton.GetComponent<Image>().sprite = equipped;
            }
        }


        

    }

    public void Equip(GameObject button)
    {
        if (PlayerPrefs.GetFloat("HighScore") >= 0)
        {
            SkydiverButton.GetComponent<Image>().sprite = owned;
        }
        else { SkydiverButton.GetComponent<Image>().sprite = locked; }
        
        if (PlayerPrefs.GetFloat("HighScore") >= 10)
        {
            AsteroidButton.GetComponent<Image>().sprite = owned;
        }
        else { AsteroidButton.GetComponent<Image>().sprite = locked; }

        if (PlayerPrefs.GetFloat("HighScore") >= 20)
        {
            UfoButton.GetComponent<Image>().sprite = owned;
        }
        else { UfoButton.GetComponent<Image>().sprite = locked; }

        if (PlayerPrefs.GetFloat("HighScore") >= 30)
        {
            ParachuterButton.GetComponent<Image>().sprite = owned;
        }
        else { ParachuterButton.GetComponent<Image>().sprite = locked; }

        if (PlayerPrefs.GetFloat("HighScore") >= 40)
        {
            DivebirdButton.GetComponent<Image>().sprite = owned;
        }
        else { DivebirdButton.GetComponent<Image>().sprite = locked; }

        if (PlayerPrefs.GetFloat("HighScore") >= 50)
        {
            HeroButton.GetComponent<Image>().sprite = owned;
        }
        else { HeroButton.GetComponent<Image>().sprite = locked; }

        button.GetComponent<Image>().sprite = equipped;
        PlayerPrefs.SetString("EquippedCharacter", button.transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
