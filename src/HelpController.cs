using System;
using SwinGameSDK;

public class HelpController
{
	/// <summary>
	/// Handles the user input during the help screen.
	/// </summary>
	/// <remarks></remarks>
	public static void HandleHelpScreenInput()
	{
		if (SwinGame.MouseClicked(MouseButton.LeftButton) || SwinGame.KeyTyped(KeyCode.vk_ESCAPE) || SwinGame.KeyTyped(KeyCode.vk_RETURN))
		{
			GameController.EndCurrentState();
		}
	}
}

