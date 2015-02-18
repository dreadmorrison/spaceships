using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class text : MonoBehaviour {

	GameObject spaceship;
	GameObject pizza;
	bool victory = false;
	
	void Start () {
		spaceship = GameObject.Find("spaceship");
		pizza = GameObject.Find ("Pizza");
	}
	
	void Update (){
		
		float dist = Vector3.Distance(pizza.transform.position,(spaceship.transform.position));
		
		string textBuffer = "You are " + dist.ToString() + " units \naway from the Pizza.";
		
		if (!victory) {
			
			if (dist < 400) {
				
				textBuffer += "\nYou found the Pizza!\nPress [SPACE] to stuff your face.";
				if (Input.GetKeyDown(KeyCode.Space)) {
					victory = true;
				}
			} else if (dist < 500) {
				textBuffer += "\nYou can almost taste it it's so close.";
			} else if (dist < 1000) {
				textBuffer += "\nYou can smell it...";
			} else {
				textBuffer += "\nYou're so hungry for pizza.";
			}
			
		} else {
			textBuffer += "\nThat pizza tasted delicious!"; 
		}
		GetComponent<Text>().text = textBuffer;
	}
}
