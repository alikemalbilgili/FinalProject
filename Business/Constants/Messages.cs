using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "Sorry,maintenance time";
        public static string ProductListed = "Products were listed";
        public static string UnitPriceInvalid;
        public static string AuthorizationDenied;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
        public static string SuccessfulLogin;
        public static string PasswordError;
        public static string UserNotFound;
        public static string UserRegistered;
    }
}
