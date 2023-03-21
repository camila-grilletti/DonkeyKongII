using System;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour {
    enum TypeMovementBot { HorizontalBounce,VerticalBounce,HorizontalFromLeft, HorizontalFromRight,VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;

    private Transform t;

    private void Awake() {
        t = GetComponent<Transform>();
    }

    private void Update() {
        try {
            switch (typeMovementRobot) {
                case TypeMovementBot.HorizontalBounce:
                    break;
                case TypeMovementBot.VerticalBounce:
                    break;
                case TypeMovementBot.HorizontalFromLeft:
                    break;
                case TypeMovementBot.HorizontalFromRight:
                    break;
                case TypeMovementBot.VerticalFromAbove:
                    break;
                case TypeMovementBot.VerticalFromBelow:
                    break;
            }
        } catch(Exception) {
            Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
        }
    }

    private void HorizontalBounce() {

    }

    private void VerticalBounce() {

    }

    private void HorizontalFromLeft() {

    }

    private void HorizontalFromRight() {

    }

    private void VerticalFromAbove() {

    }

    private void VerticalFromBelow() {

    }
}
