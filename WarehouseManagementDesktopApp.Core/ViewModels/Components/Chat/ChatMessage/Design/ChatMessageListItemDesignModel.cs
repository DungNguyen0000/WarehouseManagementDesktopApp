﻿using System;

namespace WarehouseManagementDesktopApp.Core.ViewModels
{
    /// <summary>
    /// The design-time data for a <see cref="ChatMessageListItemViewModel"/>
    /// </summary>
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListItemDesignModel Instance => new ChatMessageListItemDesignModel();
        public ICommand ClickCommand { get; set; }
        #endregion
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListItemDesignModel()
        {
            Initials = "LM";
            SenderName = "Luke";
            Message = "Some design time visual text";
            ProfilePictureRGB = "3099c5";
            SentByMe = true;
            MessageSentTime = DateTimeOffset.Now;
            MessageReadTime = DateTimeOffset.Now.Subtract(TimeSpan.FromDays(1.3));
            ClickCommand = new RelayCommand(async () => RaiseEvents());
        }

        private async void RaiseEvents()
        {
            ClickEvent?.Invoke(Id);
        }

        #endregion
    }
}
