﻿///////////////////////////////////////////////////////////////////
//
// Youbiquitous YBQ : app starter 
// Copyright (c) Youbiquitous srls 2017
//
// Author: Dino Esposito (http://youbiquitous.net)
//

using MfxDemo2.Common.Exceptions;
using MfxDemo2.Resources;

namespace MfxDemo2.Models
{
    public class ErrorViewModel : ViewModelBase
    {
        public ErrorViewModel(string message, bool isAppSpecific = false)
        {
            ErrorOccurred = new YbqAppException(message)
            {
                Title = Strings_Errors.Msg_SomethingWentWrong,
                IsAppSpecificError = isAppSpecific
            };
        }

        public YbqAppException ErrorOccurred { get; private set; }
    }
}