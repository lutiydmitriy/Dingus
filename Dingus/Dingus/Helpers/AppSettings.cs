﻿using Dingus.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Dingus.Helpers
{
    public class AppSettings
    {
        public static List<Domain> Domains
        {
            get => new List<Domain>()
            {
                new Domain() { Protocol = DomainType.Http, Port = "2456", Address = (Device.RuntimePlatform == Device.Android) ? "10.0.2.2" : "localhost" },
                new Domain() { Protocol = DomainType.Http, Port = "2314", Address = "192.168.0.104" }
            };
        }

        public static string CurrentDomain { get; set; }
        public static User CurrentUser { get; set; }

        public static string IexTradingHost { get => "https://api.iextrading.com"; }
        public static string IexTradingVersion { get => "1.0"; }

        public static List<Company> Companies { get; set; }

        public static int BaseServerTimeout { get => 5; }
        public static string StartUpPage { get => "StartUp"; }
    }
}
