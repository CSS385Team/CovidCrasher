using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour {

	// Store panel objects
	//public Button sanitizerButton, icePackButton;
	//public Text sanitizerPriceText, icePackPriceText;

	//// Game panel objects
	//public GameObject sanitizer, icePack;
	public Text strokeText;
	public int strokesAmount;

	// Common variables
	private bool isSanitizerSold, isIcePackSold;
	public int sanitizerPrice = 10, icePackPrice = 20;
	// Use this for initialization
	void Start () {
        // disable all achievements at the beginning
        //sanitizer.gameObject.SetActive (false);
        //icePack.gameObject.SetActive (false);


        //// disable buttons in the store
        //sanitizerButton.interactable = false;
        //icePackButton.interactable = false;

        // set prices for goods
        //sanitizerPriceText.text = sanitizerPrice.ToString() + " Points";
        //icePackPriceText.text = icePackPrice.ToString() + " Points";
	}
	
	// Update is called once per frame
	void Update () {
        // display gained number of Points
		strokeText.text = strokesAmount + "";
		// check if you have enough points to buy particular good
		// and it is not sold yet
		//DoYouHaveEnoughStrokesToBuySmth();					
	}

	// Increase points amount by 1 when kitten is clicked
	public void IncreaseStrokesAmount()
	{
        Debug.Log("why");
		strokesAmount += 1;
	}

	// sell sanitizer
	//public void SellSanitizer()
	//{
	//	// put hair sanitizer on kitten
	//	sanitizer.gameObject.SetActive (true);
	//	// desrease points ammount by price of sanitizer
	//	strokesAmount -= sanitizerPrice;
	//	sanitizerPriceText.gameObject.SetActive (false);
	//}

	//// sell icePack
	//public void SellIcePack()
	//{
	//	// give a kitten a icePack
	//	icePack.gameObject.SetActive (true);
	//	// desrease points ammount by price of icePack
	//	strokesAmount -= icePackPrice;
	//	icePackPriceText.gameObject.SetActive (false);
	//}
	
	//// check if you have enough points to buy particular good
	//// and it is not sold yet
	//void DoYouHaveEnoughStrokesToBuySmth()
	//{
		
	//	// disable buy sanitizer button if points is not enough
	//	if (strokesAmount < sanitizerPrice)
	//		sanitizerButton.interactable = false;

	//	// disable buy icePack button if points is not enough
	//	if (strokesAmount < icePackPrice)
	//		icePackButton.interactable = false;


	//	// if you have enough points and current good is not sold
	//	// then you can buy it
	//	if (!isSanitizerSold && strokesAmount >= sanitizerPrice)
	//	{
	//		sanitizerButton.interactable = true;
	//	}

	//	if (!isIcePackSold && strokesAmount >= icePackPrice)
	//	{
	//		icePackButton.interactable = true;
	//	}

	//}

}
