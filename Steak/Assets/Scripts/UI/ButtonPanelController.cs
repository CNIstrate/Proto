using UnityEngine.UI;
using UnityEngine;

public class ButtonPanelController : MonoBehaviour
{

	public Image JumpButton;
	public Image DuckButton;
	public Image SwapButton;

	public Color PressedColor;
	public Color ReleasedColor;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Jump"))
			setButtonDown(JumpButton);
		
		if (Input.GetButtonUp("Jump"))
			setButtonUp(JumpButton);
		
		if (Input.GetButtonDown("Sprint"))
			setButtonDown(DuckButton);
		
		if (Input.GetButtonUp("Sprint"))
			setButtonUp(DuckButton);
		
		if ((Input.GetKey(KeyCode.A) ||
             Input.GetKey(KeyCode.S) ||
             Input.GetKey(KeyCode.D) ||
             Input.GetKey(KeyCode.W)))
			setButtonDown(SwapButton);
		
		if (!(Input.GetKey(KeyCode.A) ||
             Input.GetKey(KeyCode.S) ||
             Input.GetKey(KeyCode.D) ||
             Input.GetKey(KeyCode.W)))
            setButtonUp(SwapButton);
	}


	private void setButtonDown(Image button)
	{
		button.color = PressedColor;
		button.GetComponentInChildren<Text>().color = Color.white;
	}
	
	private void setButtonUp(Image button)
	{
		button.color = ReleasedColor;
		button.GetComponentInChildren<Text>().color = Color.black;
	}


}
