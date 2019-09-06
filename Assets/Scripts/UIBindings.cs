﻿using UnityEngine;
using UnityEngine.UI;

public class UIBindings : MonoBehaviour
{
    [SerializeField]
    private Button showAlertButton;

    [SerializeField]
    private Button showAlertConfirmationButton;

    [SerializeField]
    private Button rotateUpAlertConfirmationButton;

    [SerializeField]
    private Button rotateDownAlertConfirmationButton;

    [SerializeField]
    private Button shareMessageButton;

    void Start()  
    {
        showAlertButton.onClick.AddListener(ShowBasicAlert);
        showAlertConfirmationButton.onClick.AddListener(ShowAlertConfirmation);
        rotateUpAlertConfirmationButton.onClick.AddListener(RotateUpAlertConfirmation);
        rotateDownAlertConfirmationButton.onClick.AddListener(RotateDownAlertConfirmation);
        shareMessageButton.onClick.AddListener(ShareMessage);
    }

    void ShowBasicAlert() 
    {
        iOSPlugin.ShowAlert("Basic Alert", "Hello this is a basic alert !");
    }

    void ShowAlertConfirmation()
    {
        iOSPlugin.ShowAlertConfirmation("Basic Alert Confirmation", "Hello this is a basic confirmation !", "CallBack");
    }

    void RotateUpAlertConfirmation()
    {
        iOSPlugin.ShowAlertConfirmation("Rotating Up", "Should I Rotate Up?", "RotateUpCallBack");
    }

    void RotateDownAlertConfirmation()
    {
        iOSPlugin.ShowAlertConfirmation("Rotating Down", "Should I Rotate Down?", "RotateDownCallBack");
    }

    void ShareMessage()
    {
        iOSPlugin.ShareMessage("Sharing a message!", "https://www.youtube.com/c/dilmervalecillos");
    }
}