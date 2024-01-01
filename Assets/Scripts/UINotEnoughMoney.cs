using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets
{
    public class UINotEnoughMoney : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;
        [SerializeField] private Animator _animatior;

        [Space] [SerializeField] private Text _textMoney;
        [SerializeField] private Button _CloseBtn;

        private void OnEnable()
        {
            _CloseBtn.onClick.AddListener(() => { StatePanel(false); });
        }

        public void Show(int money)
        {
            _textMoney.text = $"Don't enough money \nNeed <color=yellow>{money}</color> for purchase";
            if (!gameObject.activeSelf)
                StatePanel(true);
        }

        private void StatePanel(bool state)
        {
            if (state)
            {
                _panel.SetActive(true);
                _animatior.Play("ShowPanel");
            }
            else
            {
                _animatior.Play("HidePanel");
            }
        }

        private void OnDisable()
        {
            _CloseBtn.onClick.RemoveAllListeners();
        }
    }
}