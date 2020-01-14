using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdministrationWebApplication.Models.Shared.Settings
{
    public partial class FlowSettingsView
    {
        public byte SettingId { get; set; }
        public string SettingName { get; set; }
        public object SettingValue { get; set; }
    }
}
