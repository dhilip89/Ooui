﻿using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ooui
{
    public class Button : FormControl
    {
        ButtonType typ = ButtonType.Submit;
        public ButtonType Type {
            get => typ;
            set => SetProperty (ref typ, value, "type");
        }

        public Button ()
            : base ("button")
        {
        }

        public Button (string text)
            : this ()
        {
            Text = text;
        }
    }

    [JsonConverter (typeof (StringEnumConverter))]
    public enum ButtonType
    {
        [EnumMember (Value = "submit")]
        Submit,
        [EnumMember (Value = "reset")]
        Reset,
        [EnumMember (Value = "button")]
        Button,
    }
}
