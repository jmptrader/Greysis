using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Greysis.Domain.Const
{
    public static class UserSettingTypes
    {
        [Description("Activation max repeat")]
        public const string ActivationMaxRepeat = "ACTIVATION_MAX_REPEAT";
        [Description("Forgot password max send")]
        public const string ForgotPasswordMaxSend = "FORGOTPASSWORD_MAX_SEND";
        [Description("Last activation request date")]
        public const string ActivationSendDate = "ACTIVATION_SEND_DATE";
        [Description("Last forgot password request date")]
        public const string ForgotPasswordSendDate = "FORGOTPASSWORD_SEND_DATE";

    }
    public static class SystemSettingTypes
    {
        [Description("All system settings")]
        public const string System = "SYSTEM";
        [Description("All user settings")]
        public const string User = "USER";
    }
}
