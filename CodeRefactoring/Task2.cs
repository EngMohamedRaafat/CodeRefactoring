﻿using System;

namespace CodeRefactoring
{
    /// <summary>
    /// there are three notification services: EmailService, SmsService, and PushNotificationService. 
    /// Each service has a method to send notifications to users through different channels - email, SMS, and 
    /// push notifications, respectively.
    /// This task covers:
    /// 1. Extract Interface
    /// </summary>
    public class EmailService
    {
        public void SendNotification(string userId, string message)
        {
            // Send email notification
            Console.WriteLine($"Sending email notification to user {userId}: {message}");
        }
    }

    public class SmsService
    {
        public void SendNotification(string userId, string message)
        {
            // Send SMS notification
            Console.WriteLine($"Sending SMS notification to user {userId}: {message}");
        }
    }
    public class PushNotificationService
    {
        public void SendNotification(string userId, string message)
        {
            // Send push notification
            Console.WriteLine($"Sending push notification to user {userId}: {message}");
        }
    }
}
