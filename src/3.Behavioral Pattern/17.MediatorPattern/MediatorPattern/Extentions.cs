using System;

namespace MediatorPattern {

    public static class Extentions {

        public static string IdentitySign(this User user) {
            if (user is VipUser) {
                return $"{user.Name}[VIP]";
            }
            else if (user is GeneralUser) {
                return $"{user.Name}";
            }
            return string.Empty;
        }

    }

}