using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Speedometer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TrainMovement _trainMovement;
    [SerializeField] private string _format;

    private void Update()
    {
        _text.SetText(string.Format(_format, (int)_trainMovement.GetSpeed()));
    }
}
