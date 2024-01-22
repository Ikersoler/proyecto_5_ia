using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // poner esto es importante

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI positionText;


    private void Start()
    {
        positionText.text = "points: 0";
    }






}
