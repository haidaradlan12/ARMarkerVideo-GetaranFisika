using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class UserInterfaceButtons : MonoBehaviour
{
	public float translationSpeed = 1.0f;
	//public GameObject Model;
	bool repeatPositionUp = false;
	bool repeatPositionDown = false;
	bool repeatPositionLeft = false;
	bool repeatPositionRight = false;
	bool repeatPositionReset = false;
	
	void Update ()
	{

		if (repeatPositionUp) {
			PositionUpButton();
		}

		if (repeatPositionDown) {
			PositionDownButton();
		}

		if (repeatPositionLeft) {
			PositionLeftButton();
		}

		if (repeatPositionRight) {
			PositionRightButton();
		}
		if (repeatPositionReset) {
			PositionResetButton();
		}

	}

	public void PositionDownButtonRepeat ()
	{
		repeatPositionDown = true;
	}
	public void PositionUpButtonRepeat ()
	{
		repeatPositionUp = true;
	}
	public void PositionLeftButtonRepeat ()
	{
		repeatPositionLeft = true;
	}
	public void PositionRightButtonRepeat ()
	{
		repeatPositionRight = true;
	}
	
	public void PositionResetButtonRepeat ()
	{
		repeatPositionReset = true;
	}
	
	public void PositionRightButtonOff ()
	{
		repeatPositionRight = false;
		
	}
	public void PositionLeftButtonOff ()
	{
		repeatPositionLeft = false;
		
	}
	public void PositionUpButtonOff ()
	{
		repeatPositionUp = false;
		
	}
	public void PositionDownButtonOff ()
	{
		repeatPositionDown = false;
		
	}
	public void PositionResetButtonOff ()
	{
		repeatPositionReset = false;
		
	}
	
	

	private void PositionUpButton ()
	{
		transform.Translate (0, 0, translationSpeed * Time.deltaTime);
	}

    private void PositionDownButton ()
	{

		transform.Translate (0, 0, -translationSpeed * Time.deltaTime);
	}

    private void PositionRightButton ()
	{
		transform.Translate (translationSpeed * Time.deltaTime, 0, 0);
	}

    private void PositionLeftButton ()
	{
		transform.Translate (-translationSpeed * Time.deltaTime, 0, 0);  // backward
	}
    private void PositionResetButton ()
	{
        transform.localPosition = new Vector3(0.0f, 0.35f, 0.0f);
	}
}
