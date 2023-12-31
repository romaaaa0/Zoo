using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class UINotEnoughMoney : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;
        [SerializeField] private Animation _animation;

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
                _animation.Play("ShowPanel");
            }
            else
            {
                _animation.Play("HidePanel");
            }
        }

        private void OnDisable()
        {
            _CloseBtn.onClick.RemoveAllListeners();
        }
    }
}