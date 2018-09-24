﻿using System;
using Android.App;
using Android.Content;
using Android.Widget;
using static Android.Widget.ToastLength;
using AlertDialog = Android.Support.V7.App.AlertDialog;


namespace InstantReview.Droid.Dialogs
{
    public class DialogService : IDialogService
    {
        Context appContext = Android.App.Application.Context;

        public DialogService()
        {
        }

        private void showAlert(string text)
        {

            var stuff = Android.App.Application.Context;
            
            AlertDialog.Builder alert = new AlertDialog.Builder(appContext);
            alert.SetTitle(text);
            alert.SetMessage("General Kenobi!.");
            alert.SetPositiveButton("Hello There!", (senderAlert, args) => {
                Toast.MakeText(appContext, "Fight!!", Short).Show();
            });

            alert.SetNegativeButton("<do nothing>", (senderAlert, args) => {
                Toast.MakeText(appContext, "You escaped!", Short).Show();
            });

            Dialog dialog = alert.Create();
            dialog.Show();
        }

        void IDialogService.showAlert(string text)
        {

            AlertDialog.Builder alert = new AlertDialog.Builder(appContext);
            alert.SetTitle(text);
            alert.SetMessage("General Kenobi!.");
            alert.SetPositiveButton("Hello There!", (senderAlert, args) => {
                Toast.MakeText(appContext, "Fight!!", Short).Show();
            });

            alert.SetNegativeButton("<do nothing>", (senderAlert, args) => {
                Toast.MakeText(appContext, "You escaped!", Short).Show();
            });

            Dialog dialog = alert.Create();
            //TODO Show dialog. Need to implement AppCompat theme before that.
            Console.WriteLine("YEAAHH BOII");
        }
    }
}
