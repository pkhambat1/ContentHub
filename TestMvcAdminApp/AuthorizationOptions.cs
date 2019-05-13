﻿using Microsoft.AspNetCore.Authorization;

namespace TestMvcAdminApp {
    public class AuthorizationOptions : IAuthorizeData {
        public string Policy { get; set; }
        public string Roles { get; set; }
        public string AuthenticationSchemes { get; set; }
    }
}
