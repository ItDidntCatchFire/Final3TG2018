using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour {

    Image myImageComponent;
    public Text myText;
    public Sprite originalSprite;
    public Sprite pressedSprite;
    public string scenename;

    private int text = 0;
    void Start() //Lets start by getting a reference to our image component.
    {
        myImageComponent = GetComponent<Image>();
       
    }

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if (text == 0)
            {
                myImageComponent.sprite = pressedSprite;
                myText.text = "Your aunt has died";
            }

            if (text == 1)
            {
                myText.text = "oh no what a shame";
            }

            if (text == 2)
            {
                myText.text = "She spent her life working hard and earned a large fortune. Her biggest regret in life was not taking a break to relax. In her will she has left all of her relatives £100,000. But there is a catch...";
            }

            if (text == 3)
            {
                myText.text = "The first person to spend all that money and own no assets get the rest of the fortune. PLUS everyone elses unspent money. At the funeral your all looking at each other shiftily. Everyone one is ploting. Your cousin plans to travel the world on first class planes. Your Mom plans to buy art and sell it to the homeless. Your smug brother plans to throw a 'killer' party But you have a better idea.";
            }

            if (text == 4)
            {
                myText.text = "Straight after the funeral you race the the airport. And you hop onto the first flight to the distant land of America. Nothing is more expensive than premium american healthcare.";
            }

            if (text == 5)
            {
                SceneManager.LoadScene(scenename);
            }
            text++;
        }
      //  else if (Input.GetButton("Submit"))
        //{
         //   myImageComponent.sprite = originalSprite;
        //}
    }
}
