﻿using System;
using Autofac;
using InstantReview.Droid.Dialogs;


namespace InstantReview.Droid
{
    public static class ContainerCreator
    {
        public static ContainerBuilder CreateContainerBuilder(MainActivity activity)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DialogService>().As<IDialogService>().SingleInstance();

            return builder;
        }
    }
}
