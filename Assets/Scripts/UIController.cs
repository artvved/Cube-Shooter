using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private GameController gameController;

        [Header("UI")] [SerializeField] private GameObject inputMenu;
        [SerializeField] private Button acceptButton;
        [SerializeField] private TMP_InputField reloadTimeInputField;
        [SerializeField] private TMP_InputField distanceInputField;
        [SerializeField] private TMP_InputField velocityInputField;

        private const string INVALID_INPUT = "Invalid input";

        private void Awake()
        {
            acceptButton.onClick.AddListener(InitShooting);
        }

        private void InitShooting()
        {
            var valid1 = TryGetInput(reloadTimeInputField, out float time);
            var valid2 = TryGetInput(distanceInputField, out float distance);
            var valid3 = TryGetInput(velocityInputField, out float velocity);
            if (valid1 && valid2 && valid3)
            {
                gameController.InitShooting(time, distance, velocity);
                inputMenu.gameObject.SetActive(false);
            }
            
        }

        private bool TryGetInput(TMP_InputField inputField, out float time)
        {
            var valid = float.TryParse(inputField.text, out time);
            if (valid)
            {
                return true;
            }
            else
            {
                inputField.text = INVALID_INPUT;
                return false;
            }
        }
    }
}