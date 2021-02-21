using UnityEngine;

public class Player: MonoBehaviour {

	private InputMaster controls;

	private void Awake() {
		controls = new InputMaster();
		controls.Player.Shoot.performed += _ => Shoot();
		controls.Player.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
	}

	void Shoot() {
		Debug.Log("We Shot the sherif!");
	}

	void Move(Vector2 direction) {
		Debug.Log("Player wants to move: " + direction);
	}

	private void OnEnable() {
		controls.Enable();
	}

	private void OnDisable() {
		controls.Disable();
	}

}
